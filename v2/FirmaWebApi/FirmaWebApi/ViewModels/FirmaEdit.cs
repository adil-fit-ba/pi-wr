using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirmaWebApi.DB;

namespace FirmaWebApi.ViewModels
{
    public class FirmaEdit
    {
        public int ID;
        public string Naziv;
        public string Adresa;
        public int OpstinaID;

        public string JIB;
        public string PDVBroj;
    }
}