

using System.Text.Json.Serialization;

namespace BaseLibrary.Models
{
    public class OvertimeType :BaseModel
    {
        //Many to one relationship with Overtime
        [JsonIgnore]
        public List<Overtime>? Overtimes { get; set; }
    }
}
