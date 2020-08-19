using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deliverable2.Controllers
{
    public class UserRegistrationController : Controller
    {
        // GET: UserRegistration
        public ActionResult UserRegistration()
        {
            return View();
        }

        //public ActionResult EmployerFreelancer(String Dropdown)
        //{
          

        //    //if (Dropdown == "0")
        //    //{
        //    //    ViewBag.message = "invalid";
        //    //}
        //    //else if (Dropdown == "1")
        //    //{
        //    //   return RedirectToAction("FreelancerRegistration", "UserRegistration");
        //    //}

        //    //else if (Dropdown == "2")
        //    //{
        //    //   return RedirectToAction("EmployerRegistration", "UserRegistration");
        //    //}
        //  return View()
        //}



        public ActionResult FreelancerRegistration()
        {
            return View();
        }
        public ActionResult EmployerRegistration()
        {
            return View();
        }
    }
}