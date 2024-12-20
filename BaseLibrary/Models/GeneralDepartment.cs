using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BaseLibrary.Models
{
    public class GeneralDepartment : BaseModel
    {
        //One to many relationship with Department
        [JsonIgnore]
        public List<Department>? Departments { get; set; }
    }
}
