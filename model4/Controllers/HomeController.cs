using model4.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace model4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        [HttpGet]
        public ActionResult Rectangle()
        {

            return View();
        }

        [HttpPost]

        public ActionResult Rectangle(Area std)
        {
            int a = std.Length * std.Breadth;
            ViewBag.result = "Area of the rectangle is  : " + a;
            return View();
        }

        // Create action method having name marks and find average marks of 5 subject . Use passing name of form - control as action method parameter 
        [HttpGet]
        public ActionResult Subject() 
        {
            return View();
        }

        [HttpPost]

        public ActionResult Subject( string name, int marks1, int marks2, int marks3, int marks4, int marks5)
        {
            string bc = name + " || The average marks of this student is : ";
            int avg = (marks1 + marks2 + marks3 + marks4 + marks5)/5 ;
            ViewBag.Res = bc;
            ViewBag.Result = avg;
            return View();
        }
    }

}