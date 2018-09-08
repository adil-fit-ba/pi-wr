using FirmaWebApi.DB;
using FirmaWebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FirmaWebApi.Controllers
{
    public class RacunajController:Controller
    {
        public ActionResult Stepenuj(int a, int b)
        {
            double r = Math.Pow(a, b);

            ViewData["rKey"] = r;

            return View("Rezultat");
        }

        public string Kvadriraj(int a)
        {
            return (a *a).ToString();
        }

        public ActionResult Proba()
        {
            return View("Proba");
        }
       
    }
}