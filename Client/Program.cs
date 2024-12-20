using BaseLibrary.Models;
using Blazored.LocalStorage;
using Client;
using Client.ApplicationStates;
using ClientLibrary.Helpers;
using ClientLibrary.Services.Contracts;
using ClientLibrary.Services.Implementations;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ServerLibrary.Repositories.Contracts;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Popups;
using Syncfusion.Licensing;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddTransient<CustomHttpHandler>();
builder.Services.AddHttpClient("SystemApiClient", client =>
{
    client.BaseAddress = new Uri("http://localhost:5287/");
}).AddHttpMessageHandler<CustomHttpHandler>(); ;

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7183")});


builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<GetHttpClient>();
builder.Services.AddScoped<LocalStorageService>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddScoped<IUserAccountService, UserAccountService>();

// General Department / Department / Branch
builder.Services.AddScoped<IGenericServiceInterface<GeneralDepartment>, GenericServiceImplementation<GeneralDepartment>>();
builder.Services.AddScoped<IGenericServiceInterface<Department>, GenericServiceImplementation<Department>>();
builder.Services.AddScoped<IGenericServiceInterface<Branch>, GenericServiceImplementation<Branch>>();

// Country / City / Town
builder.Services.AddScoped<IGenericServiceInterface<Country>, GenericServiceImplementation<Country>>();
builder.Services.AddScoped<IGenericServiceInterface<City>, GenericServiceImplementation<City>>();
builder.Services.AddScoped<IGenericServiceInterface<Town>, GenericServiceImplementation<Town>>();

// Employee
builder.Services.AddScoped<IGenericServiceInterface<Employee>, GenericServiceImplementation<Employee>>();

builder.Services.AddScoped<IGenericServiceInterface<Doctor>, GenericServiceImplementation<Doctor>>();


builder.Services.AddScoped<AllState>();


builder.Services.AddSyncfusionBlazor();
builder.Services.AddScoped<SfDialogService>();

SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NMaF5cXmZCf0x3Q3xbf1x1ZFxMYV1bRXBPIiBoS35RckRhWHZeeHZdR2BYUk1+");

await builder.Build().RunAsync();
