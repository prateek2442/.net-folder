using CAMPUS_FIX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CAMPUS_FIX.Controllers
{
    public class AdminController : Controller
    {
        ComplaintdbEntities adb = new ComplaintdbEntities();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ManageComplaint()
        {

            return View();
        }
        public ActionResult ManageEnquiry()
        {
                
            List<Enquiry_Master> lst = adb.Enquiry_Master.OrderByDescending(x=>x.EnqId).ToList();
            return View(lst);
        }

        public ActionResult DeleteEnquiry(int id)
        {
            string msg = "";
            try
            {
               Enquiry_Master em = adb.Enquiry_Master.Find(id);
                if (em != null)
                {
                    adb.Enquiry_Master.Remove(em);
                    adb.SaveChanges();

                    msg = "Record deleted successfully";
                }
            }
            catch
            {
                msg = "technical issue occurred!";
            }

            TempData["Message"] = msg;
            return RedirectToAction("ManageEnquiry", "Admin");
        }

        [HttpGet]
        public ActionResult Notification()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Notification(Notification_Master nm)
        {
            string msg = "";
            try
            {
                nm.AddedOn = DateTime.Now;
                adb.Notification_Master.Add(nm);
                adb.SaveChanges();

                msg = "Notification Added Successfully";

            }
            catch
            {
                msg = "Sorry! Technical issue occured!";
            }
            
            ViewBag.message =msg;

            return View();
        }
    }
}