using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirmaWebApi.DB;

namespace FirmaWebApi.ViewModels
{
    public class FirmaPrikazi
    {
        public int ID;
        public string Naziv;
        public string Adresa;
        public int BrojRacuna;
        public decimal? IznosBezPDV;
        public decimal? IznosSaPDV;
        private Firma x;

       
    }
}