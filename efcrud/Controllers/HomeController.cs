using efcrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace efcrud.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        smsdbEntities db = new smsdbEntities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {

            return View();
        }

        [HttpPost]

        public ActionResult Register( stdmaster s)
        {
            string msg = "";
            try
            {
                db.stdmasters.Add(s);
                db.SaveChanges();
                msg = "recorded";
                
            }
            catch
            {
                msg = "error";
            }
            ViewBag.message = msg;
            return View();
        }

        public ActionResult ManageStudent()
        {
            List<stdmaster> lst = db.stdmasters.ToList();
            return View(lst);

        }

        public ActionResult UpdateStudent()
        {
            return View();
        }

        public ActionResult DeleteStudent()
        {
            return View();
        }
    }
}