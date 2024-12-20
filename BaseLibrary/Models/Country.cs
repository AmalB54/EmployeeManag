

using System.Text.Json.Serialization;

namespace BaseLibrary.Models
{
    public class Country :BaseModel
    {
        //One to many relationship with city
        [JsonIgnore]
        public List<City>? Cities { get; set; }
    }
}
