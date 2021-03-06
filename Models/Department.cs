using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sens_Hospital.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentPhoneNumber { get; set; }
    }

    public class DepartmentDto
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentPhoneNumber { get; set; }
    }
}