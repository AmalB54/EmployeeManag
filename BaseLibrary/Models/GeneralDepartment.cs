﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Models
{
    public class GeneralDepartment : BaseModel
    {
        //One to many relationship with Department
        public List<Department>? Departments { get; set; }
    }
}
