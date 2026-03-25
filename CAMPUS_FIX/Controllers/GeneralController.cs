using CAMPUS_FIX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CAMPUS_FIX.Controllers
{
    public class GeneralController : Controller
    {

        ComplaintdbEntities db = new ComplaintdbEntities();

        // GET: General
        public ActionResult Index()
        {
            // to show notification

            List<Notification_Master> lst=db.Notification_Master.OrderByDescending(x => x.NotiId).Take(3).ToList();
            return View(lst);
        }

        public ActionResult TrackPage()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]

        public ActionResult ContactUs(Enquiry_Master cu)
        {
            string msg = "";
            try
            {
                cu.EnquiryDate = DateTime.Now;
                db.Enquiry_Master.Add(cu);
                db.SaveChanges();
                msg = "thanks for your sending your contact!. We will contact you soon!";
            }
            catch
            {
                msg = "Sorry! some Technical issue occured";
            }

            TempData["Message"] = msg;
            return RedirectToAction("response");
            
        }
        public ActionResult ReportComplaint()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ReportComplaint(Complaint_Master cm)
        {
            string msg = "";
            try
            {
                cm.ReportDate = DateTime.Now;
                db.Complaint_Master.Add(cm);
                db.SaveChanges();
                msg = "thanks for your Enquiry!. We will contact you soon!";
                
            }
            catch
            {
                msg = "Sorry! some Technical issue occured";
            }
            TempData["message"] = msg;
            return RedirectToAction("ReportComplaint");
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult DeveloperPage ()
        {
            return View();
        }

        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]

        public ActionResult AdminLogin(login_Master lm)
        {
            login_Master lmdb = db.login_Master.SingleOrDefault(x => x.AdminId == lm.AdminId && x.Password == lm.Password);
            if(lmdb != null)
            {
                Session["Aid"]= lmdb.AdminId;
                return RedirectToAction("Index","Admin");
            }
            else
            {
                ViewBag.message = "Login Failed";
            }
            return View();
        }

        //Save Enquiry

        public ActionResult SaveEnquiry(Enquiry_Master em)
        {
            string msg = "";
            try
            {
                em.EnquiryDate = DateTime.Now;
                db.Enquiry_Master.Add(em);
                db.SaveChanges();
                msg = "thanks for your Enquiry!. We will contact you soon!";

                mailer m = new mailer();
                em.Message = "thanks for your Enquiry.We will contact you soon.";
                m.SendMyEmail(em.Email, em.Subject, em.Message);
            }
            catch
            {
                msg = "Sorry! some Technical issue occured" ;
            }

            TempData["Message"] = msg;
            return RedirectToAction("response");
        }

        public ActionResult response()
        {
            return View();
        }
    }
}