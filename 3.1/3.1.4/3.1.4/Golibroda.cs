using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _3._1._4
{
    class Golibroda
    {
        Poczekalnia kolejka;
        public Golibroda(Poczekalnia kolejka)
        {
            this.kolejka = kolejka;
        }

        public void Run(){
            while (true)
            {
                if (kolejka.Kolejka.Count == 0)
                {
                    Thread.CurrentThread.Suspend();
                }
                else
                {
                    kolejka.Kolejka.Dequeue();
                }
            }
        }
    }
}
