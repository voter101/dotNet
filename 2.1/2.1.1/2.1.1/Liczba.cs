using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._1
{
    class Liczba
    {
        public int wartosc;
        public bool czyPodzielna { get; set; }
        public Liczba(int wartosc)
        {
            this.wartosc = wartosc;
            czyPodzielna = true;
        }
    }
}
