using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _3._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Poczekalnia kolejka = new Poczekalnia();
            Golibroda golibroda = new Golibroda(kolejka);
            Thread watekGolibrody = new Thread(new ThreadStart(golibroda.Run));
            
            Klient klient = new Klient(watekGolibrody, kolejka);
            Thread watekKlienta = new Thread(new ThreadStart(klient.Run));

            watekGolibrody.Start();
            watekKlienta.Start();
            Queue<string> fifo = kolejka.Kolejka;
            while (true)
            {
                if (fifo.Count != 8)
                {
                    Console.WriteLine(fifo.Count);
                }
            }

        }
    }

}
