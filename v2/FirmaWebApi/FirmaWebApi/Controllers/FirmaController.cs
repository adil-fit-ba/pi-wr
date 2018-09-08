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
    public class FirmaController:Controller
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
        public ActionResult Obrisi(int id)
        {
            firma3Entities db = new firma3Entities();
            Firma f  = db.Firma.Find(id);

            db.Firma.Remove(f);
            db.SaveChanges();

           return  new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        public ActionResult Prikazi()
        {
            firma3Entities db = new firma3Entities();

            List<FirmaPrikazi> firme = db.Firma.Select(s => new FirmaPrikazi {
                ID=s.ID,
                Naziv = s.Naziv,
                JIB = s.JIB,
                PDVBroj = s.PDVBroj,
                Adresa = s.Adresa,
                Opstina = s.Opstina.Naziv,
                BrojRacuna = s.Racun.Count,
                IznosBezPDV = s.Racun.Sum(r=>(decimal?) r.Iznos),
                IznosSaPDV = s.Racun.Sum(r=> (decimal?)(r.Iznos * (decimal) 1.17))

            }).ToList(); ;

            

            return Json(firme, JsonRequestBehavior.AllowGet);

        }
    }
}