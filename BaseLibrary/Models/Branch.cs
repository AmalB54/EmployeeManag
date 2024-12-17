using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Models
{
    public class Branch:BaseModel
    {
        //Many to one relationship with Department
        public Department? Department { get; set; }
        public int DepartmentId { get; set; }
        //Relationship : One to Many Employee
        public List<Employee>? Employees { get; set; }
    }
}
