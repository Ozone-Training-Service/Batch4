using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website2.Helpers;
using Website2.Models;

namespace Website2.Controllers
{
    public class StudentController : Controller
    {

        //
        public IActionResult Index()
        {


            ViewBag.Name = "Vishnu kumar";


            ViewBag.Email = "vishnu@gmail.com";
            return View();
        }


        [HttpGet]
        public IActionResult addStudent(string n1, string address)
        {


            Report obj = new Report();
            obj.createReport(n1,address);

            
           

            


            ViewBag.Name = n1;
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        //


       [HttpPost]
        public IActionResult addStudent2(Student student)
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