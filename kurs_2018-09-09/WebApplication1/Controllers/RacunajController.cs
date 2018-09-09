using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class RacunajController:Controller
    {
        public string Proba()
        {
            return "Hello proba";
        }

        public int Kvadriraj(int a)
        {
            return a * a;
        }

        public float Saberi(float a, float b)
        {
            return a + b;
        }

        public float Pomnozi(float a, float b)
        {
            return a * b;
        }
    }
}