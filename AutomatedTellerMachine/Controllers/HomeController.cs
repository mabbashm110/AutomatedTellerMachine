using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        //GET /home/index
        public ActionResult Index()
        {
            return View();
        }

        //GET /home/about
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Foo()
        {
            var serial = "TestingFoo";

            //Alias for Contact Page
            //return View("Contact");       //Renders complete webpage

            //return PartialView("Contact");  //Renders partial webpage without CSS, only basic HTML

            //Returns Json, needs ReqBehaviour to avoid injecting js code
            /*return Json(new { name = "serial", value = serial }, 
                JsonRequestBehavior.AllowGet);  */
            //TO TEST Json Type, Use Chrome Dev Tools, Network, Refresh Page, Headers, Content-Type:application/json

            return RedirectToAction("Index");   //Ideal for Thank you pages or redirect when to a specific page after a process is done
            //You can also redirect to a different controller and action

        }

        //For MAPROUTE Serial
        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVC5";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            return Content(serial);
        }
    }
}