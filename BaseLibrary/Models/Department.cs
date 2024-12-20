using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BaseLibrary.Models
{
    public class Department : BaseModel
    {
        //Many to one relationship Department
        public GeneralDepartment? GeneralDepartment { get; set; }
        public int GeneralDepartmentId {  get; set; }
        //One to many relationship with Branch
        [JsonIgnore]
        public List<Branch>? Branches { get; set; }
    }
}
