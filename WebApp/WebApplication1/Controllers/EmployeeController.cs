﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AddEmployee()
        {
            return View();
        }



        public IActionResult EmployeeList()
        {
            return View();
        }




    }
}