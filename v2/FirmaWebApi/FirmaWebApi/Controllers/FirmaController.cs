﻿using FirmaWebApi.DB;
using FirmaWebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace FirmaWebApi.Controllers
{
    public class FirmaController:Controller
    {
        firma3Entities db = new firma3Entities();

        public ActionResult Obrisi(int id)
        {
            Firma f  = db.Firma.Find(id);

            db.Firma.Remove(f);
            db.SaveChanges();

           return  new HttpStatusCodeResult(HttpStatusCode.OK);
        }
        [System.Web.Mvc.HttpPost]
        public ActionResult Snimi(FirmaEdit input)
        {
            Firma f;
            if (input.ID == 0)
            {
                f = new Firma();
                db.Firma.Add(f);
            }
            else
            {
                f = db.Firma.Find(input.ID);
            }

            f.JIB = input.JIB;
            f.OpstinaID = input.OpstinaID;
            f.Naziv = input.Naziv;
            f.PDVBroj = input.PDVBroj;
            f.Adresa = input.Adresa;

            db.SaveChanges();


            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }


        public ActionResult Prikazi()
        {
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

        
        public ActionResult GetByID(int ID)
        {
            FirmaEdit f = db.Firma.Where(x => x.ID==ID).Select(s => new FirmaEdit
            {
                ID = s.ID,
                Naziv = s.Naziv,
                JIB = s.JIB,
                PDVBroj = s.PDVBroj,
                Adresa = s.Adresa,
                OpstinaID = s.OpstinaID,
            }).SingleOrDefault(); 
            

            return Json(f, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetOpstine()
        {
            var f = db.Opstina.Select(s => new {
                ID = s.ID,
                Naziv = s.Naziv,
            }).ToList();

            return Json(f, JsonRequestBehavior.AllowGet);
        }
    }
}