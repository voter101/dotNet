using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serwer
{
    public class Samochod
    {
        public string rejestracja { get; set; }
        public int pojemnoscSilnika { get; set; }
        public string marka { get; set; }



        public override string ToString()
        {
            return string.Format("Samochod marki : {0}, o rejestracji {1} io pojemnosci silnika = {2}", marka, rejestracja, pojemnoscSilnika);
        }
    }
}
