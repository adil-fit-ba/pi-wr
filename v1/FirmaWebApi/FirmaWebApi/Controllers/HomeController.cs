using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirmaWebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View("Index");
        }

        public ActionResult Prikazi()
        {
            ViewBag.Title = "Home Page";

            return View("Index");
        }

        public ActionResult Preusmjeri()
        {
            ViewBag.Title = "Home Page";

            return Redirect("http://fit.ba");
        }

        public string Proba()
        {

            return "<h2>hellp</h2>";
        }
    }
}
