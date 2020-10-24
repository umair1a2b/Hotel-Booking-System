using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();

        public ActionResult index()
        {
            return View();
        }

        public ActionResult about()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult elements()
        {
            ViewBag.Message = "elements  page.";

            return View();
        }
        public ActionResult blog()
        {
            ViewBag.Message = "Your blog page.";

            return View();
        }
        public ActionResult rooms()
        {
            ViewBag.Message = "rooms page.";

            return View();
        }
        public ActionResult singleblog()
        {
            ViewBag.Message = " single blog";

            return View();
        }
        public ActionResult db()
        {
            return View(dc.Bookings.ToList());

            return View();
        }
        public ActionResult Add()
        {
            string check_in = Request["check_in"];
            string check_out = Request["check_out"];
            string adult = Request["adult"];
            string children = Request["children"];
            string room_type = Request["room_type"];
            string Customer_id = Request["Customer_id"];
            Booking b = new Booking();
            b.check_in = check_in;
            b.check_out = check_out;
            b.no_children = int.Parse(children);
            b.no_adult = int.Parse(adult);
            b.room_type = room_type;
            b.Customer_id = int.Parse(Customer_id);

            dc.Bookings.InsertOnSubmit(b);
            dc.SubmitChanges();

            return RedirectToAction("rooms");
        }
        public ActionResult Edit(int id)
        {
            return View(dc.Bookings.First(s => s.Customer_id == id));
        }

        public ActionResult EditOK(Booking b)
        {
            //r a = dc.Bookings.First(s => s.Customer_id == b.Customer_id);
            var a = (from d in dc.Bookings where d.Customer_id == b.Customer_id select d).SingleOrDefault();
             String check_in = Request["check_in"];
             String check_out = Request["check_out"];
             String no_adult = Request["adult"];
             String no_children = Request["children"];
             String room_type = Request["room_type"];

        a.check_in = check_in;
        a.check_out = check_out;
        a.no_children = int.Parse(no_children);
        a.no_adult = int.Parse(no_adult);
        a.room_type = room_type;
            dc.SubmitChanges();
            return RedirectToAction("db");
        }

        public ActionResult Delete(int id)
        {
            var s = dc.Bookings.First(x => x.Customer_id == id);
            dc.Bookings.DeleteOnSubmit(s);
            dc.SubmitChanges();
            return RedirectToAction("db");
        }
        public ActionResult login()
        {
            return View();
        }
        public ActionResult login1()
        {
            return View();
        }
        public ActionResult signup1()
        {
            return View();
        }
       

        public ActionResult loginMe()
        {
            string Uname = Request["user_name"];
            string Upass = Request["user_password"];

            var query = dc.Users.Where(a => a.USERNAME == Uname && a.PASSWORD == Upass).FirstOrDefault();

            if (query != null) //  User Exists
            {
                return RedirectToAction("index");
            }
            else
            {
                return RedirectToAction("login");  // Stay
            }

        }
        public ActionResult signup()
        {
            return View();
        }

        public ActionResult signupMe()
        {
            
            string Uname = Request["user_name"];
            string Uemail = Request["user_email"];
            string Upass = Request["user_password"];
            string Ugender = Request["user_gender"];
           

            var query = dc.Users.Where(a => a.USERNAME == Uname).FirstOrDefault();
            if (query != null)
            {
                return RedirectToAction("signup");
            }
        
            {
                //  Submit DB
                User us = new User();
                us.USERNAME = Uname;
                us.EMAIL = Uemail;
                us.PASSWORD = Upass;
                us.GENDER = Ugender;
                dc.Users.InsertOnSubmit(us);
                dc.SubmitChanges();
                return RedirectToAction("login");
            }
        }
    }
}
