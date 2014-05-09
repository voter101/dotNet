using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._4
{
    class Poczekalnia
    {
        private Queue<string> kolejka;
        private static readonly object lockK = new object();

        public Poczekalnia()
        {
            this.kolejka = new Queue<string>();
        }

        public Queue<string> Kolejka
        {
            get
            {
                lock (lockK)
                {
                    return kolejka;
                }
           }
        }
    }
}
