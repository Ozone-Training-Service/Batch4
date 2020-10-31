using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website2.Models;

namespace Website2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Employee newEmployee)
        {

            ViewBag.Name = newEmployee.FirstName;
            return View();
        }
    }
}