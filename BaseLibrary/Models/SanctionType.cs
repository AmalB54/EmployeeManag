

using System.Text.Json.Serialization;

namespace BaseLibrary.Models
{
    public class SanctionType : BaseModel
    {
        //Many to one relationship with vacation
        [JsonIgnore]
        public List<Sanction>? Sanctions { get; set; }
    }
}
