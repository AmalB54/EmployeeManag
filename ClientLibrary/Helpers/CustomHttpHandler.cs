using BaseLibrary.DTOs;
using ClientLibrary.Services.Contracts;
using System.Net;
using System.Threading;

namespace ClientLibrary.Helpers
{
    public class CustomHttpHandler
        (GetHttpClient getHttpClient, LocalStorageService localStorageService, IUserAccountService accountService
        ) : DelegatingHandler
    {
        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            bool loginUrl = request.RequestUri.AbsoluteUri.Contains("login");
            bool registerUrl = request.RequestUri.AbsoluteUri.Contains("register");
            bool refreshTokenUrl = request.RequestUri.AbsoluteUri.Contains("refresh-token");

            if (loginUrl || registerUrl || refreshTokenUrl)
            {
                return await base.SendAsync(request, cancellationToken);
            }

            var result = await base.SendAsync(request, cancellationToken);

            if (result.StatusCode == HttpStatusCode.Unauthorized)
            {
                try
                {
                    var stringToken = await localStorageService.GetToken();
                    if (string.IsNullOrEmpty(stringToken))
                        return result;

                    var deserializedToken = Serializations.DeserializeJsonString<UserSession>(stringToken);
                    if (deserializedToken == null)
                        return result;

                    // Vérifiez si le jeton existe déjà dans les en-têtes
                    if (request.Headers.Authorization == null)
                    {
                        request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", deserializedToken.Token);
                        return await base.SendAsync(request, cancellationToken);
                    }

                    // Rafraîchir le jeton
                    var newJwtToken = await GetRefreshToken(deserializedToken.RefreshToken!);
                    if (string.IsNullOrEmpty(newJwtToken))
                        return result;

                    request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", newJwtToken);
                    return await base.SendAsync(request, cancellationToken);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error handling unauthorized request: {ex.Message}");
                    return result; // Retournez le résultat original en cas d'échec
                }
            }

            return result;
        }

        private async Task<string> GetRefreshToken(string refreshToken)
        {
            var result = await accountService.RefreshTokenAsync(new RefreshToken() { Token = refreshToken });

            if (result == null || string.IsNullOrEmpty(result.Token) || string.IsNullOrEmpty(result.RefreshToken))
            {
                throw new Exception("Failed to refresh token. Invalid response from server.");
            }

            var serializedToken = Serializations.SerializeObj(new UserSession
            {
                Token = result.Token,
                RefreshToken = result.RefreshToken
            });

            await localStorageService.SetToken(serializedToken);

            return result.Token;
        }
    }
}
