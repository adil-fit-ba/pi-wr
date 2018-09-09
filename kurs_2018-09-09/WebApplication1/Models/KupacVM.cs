using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class KupacVM
    {
        public string Ime { get; set; }
        public string Adresa { get; set; }
        public double FaktureSumaTekuceGodine { get; set; }
        public double FaktureSumaUkupno { get; set; }
        public DateTime? ZadnjaFaktura { get; set; }
    }
}