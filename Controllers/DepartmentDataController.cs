using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sens_Hospital.Models;

namespace Sens_Hospital.Controllers
{
    public class DepartmentDataController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DepartmentData
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetDepartments()
        {
            List<Department> Departments = db.Departments.ToList();
            List<DepartmentDto> DepartmentDtos = new List<DepartmentDto>();

            foreach (var department in Departments)
            {
                DepartmentDto NewDepartment = new DepartmentDto
                {
                    DepartmentID = department.DepartmentID,
                    DepartmentName = department.DepartmentName,
                    DepartmentPhoneNumber = department.DepartmentPhoneNumber
                };
                DepartmentDtos.Add(NewDepartment);
            }

            return View(DepartmentDtos);
        }
    }
}