

namespace BaseLibrary.Models
{
    public class Country :BaseModel
    {
        //One to many relationship with city
        public List<City>? Cities { get; set; }
    }
}
