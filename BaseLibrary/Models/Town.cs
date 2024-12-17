﻿

namespace BaseLibrary.Models
{
    public class Town:BaseModel
    {
        //Relationship : One to Many with Employee
        public List<Employee>? Employees { get; set; }

        //Many to one relationship with city
        public City? City { get; set; }
        public int CityId { get; set; }

    }
}
