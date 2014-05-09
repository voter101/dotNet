using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _3._1._4
{
    class Klient
    {
        Thread golibroda;
        Poczekalnia kolejka;
        public Klient(Thread golibroda, Poczekalnia kolejka) 
        {
            this.golibroda = golibroda;
            this.kolejka = kolejka;
        }

        public void Run()
        {
            while (true)
            {
                if (golibroda.ThreadState == ThreadState.Suspended)
                {
                    golibroda.Resume();
                }
                else if (kolejka.Kolejka.Count <= 7)
                {
                    kolejka.Kolejka.Enqueue("klient");
                }
            }
        }

    }
}
