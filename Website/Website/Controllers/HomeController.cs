using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteDomain;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        private ServiceReference1.IService1 service;

        public HomeController()
        {
            service = new ServiceReference1.Service1Client();

        }

        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(User u)
        {
            if (!u.Naam.Equals("") && ModelState.IsValid)
            {
                service.AddGebruiker(u);
            }


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Over ons.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact pagina.";

            return View();
        }


    }
}