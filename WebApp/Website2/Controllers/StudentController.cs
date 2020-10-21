using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Website2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {


            ViewBag.Name = "Vishnu kumar";


            ViewBag.Email = "vishnu@gmail.com";
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }


        public string Hello()
        {
            return "hello";
        }
    }
}