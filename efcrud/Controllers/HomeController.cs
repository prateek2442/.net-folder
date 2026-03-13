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

         smsdbEntities1 db = new smsdbEntities1();
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

        [HttpGet]

        public ActionResult UpdateStudent(int Id)
        {

            stdmaster st = db.stdmasters.Find(Id);

            return View(st);
        }

        [HttpPost]

        public ActionResult UpdateStudent(stdmaster s)
        {
            string msg = "";
            try
            {
                stdmaster stdb = db.stdmasters.SingleOrDefault(x => x.Id == s.Id);
                if (stdb != null)
                {
                    stdb.Name = s.Name;
                    stdb.Age = s.Age;
                    stdb.Email = s.Email;
                    stdb.MobNo = s.MobNo;
                    db.Entry(stdb); 
                    db.SaveChanges();
                    msg = "Record updated successfully";
                }
                else
                {
                    msg = "Record not found";
                }
            }
            catch
            {
                msg = "error!";
            }

            TempData["Message"] = msg;
            return RedirectToAction("ManageStudent");
        }


        public ActionResult DeleteStudent( int Id)
        {
            string msg = "";
            try
            {
                stdmaster dl = db.stdmasters.Find(Id);
                if (dl != null) 
                {
                    db.stdmasters.Remove(dl);
                    db.SaveChanges();
                    msg = "deleted successfully";
                }
            }

            catch
            {
                msg = "error!";
            }

            TempData["Message"] = msg;
            return RedirectToAction("ManageStudent");
        }
    }
}