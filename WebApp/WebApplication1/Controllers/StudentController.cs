﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
         
            return View();
        }


        public IActionResult page2()
        {

            return View();
        }


        public IActionResult page3()
        {

            return View();
        }


        public string Hello()
        {
            return "Vishnu";
        }
    }
}