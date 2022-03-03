/* Title- HomeAppliances Shopping Application
    Author- Madujith M A
    Date Of creation -21/01/2022
    Modified on -24/01/2022
     Description -This is a Online Home Appliances shopping WEb application using Asp.net mvc 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homeappliences_application.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
       
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
    }
}