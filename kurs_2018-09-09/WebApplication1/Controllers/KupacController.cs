using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class KupacController:Controller
    {
        public JsonResult GetAll1()
        {
            pi5aEntities db = new pi5aEntities();

            List<KupacVM> podaci = db.Kupac
                                .Select(x => new KupacVM
                                {
                                    Adresa = x.Adresa + " " + x.Grad,
                                    Ime = x.Naziv,
                                    ZadnjaFaktura = x.Faktura.OrderByDescending(o => o.Datum).FirstOrDefault().Datum,
                                    FaktureSumaUkupno = x.Faktura.Sum(s => s.Iznos),
                                    FaktureSumaTekuceGodine = 0
                                }).ToList();

            return Json(podaci, JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetAll2()
        {
            pi5aEntities db = new pi5aEntities();

            List<KupacView> podaci = db.KupacView.ToList();

            return Json(podaci, JsonRequestBehavior.AllowGet);
        }

    }
}