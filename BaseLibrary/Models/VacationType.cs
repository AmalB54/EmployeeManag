

using System.Text.Json.Serialization;

namespace BaseLibrary.Models
{
    public class VacationType : BaseModel
    {
        //Many to one relationship with Vacation
        [JsonIgnore]
        public List<Vacation>? Vacations { get; set; }
    }
}
