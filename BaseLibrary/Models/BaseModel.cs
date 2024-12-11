using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BaseLibrary.Models
{
    public class BaseModel
    {
        public int id {  get; set; }
        public string? name { get; set; }
        //Relationship one to many
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }
    }
}
