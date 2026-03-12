using model3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace model3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Demo()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddNum()
        {
            return View();
        }
        [HttpPost]

        public ActionResult AddNum( int tnum1, int tnum2)
        {
            int res = tnum1 + tnum2;
            ViewBag.Result = "Addition of the number is : " + res; 
            return View();
        }

        [HttpGet]
        public ActionResult Info()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Info(string uName, int uAge, int uRollno, string uEmail)
        {
            string a = "name : " + uName + " Age : " + uAge + " Rollno : " + uRollno + " Email  :" + uEmail;
            ViewBag.Result = a;
            return View();
        }

        [HttpGet]
        public ActionResult StudentDetail()
        {
            return View();
        }
        [HttpPost]

        public ActionResult StudentDetail(Student abc)
        {
            ViewBag.Student ="ID is : " + abc.Id + " Name is  : " +  abc.Name + " Rollno : " + abc.Rollno + " AGE : " + abc.Age + " email :" + abc.Email;
            return View();
        }

        public ActionResult Contacts()
        {
            return View();
        }
    }
}