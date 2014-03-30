using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ListaLiczb = new List<int>();
            for (int i = 1; i <= 100000; i++)
            {
                Liczba aktualny = new Liczba(i);
                
                int sumaCyfr = 0;
                int liczba = i;

                while (liczba > 0)
                {
                    int kolejna_cyfra = liczba % 10;
                    if (kolejna_cyfra == 0)
                    {
                        sumaCyfr = 1;
                        aktualny.czyPodzielna = false;
                        break;
                    }
                    liczba /= 10;
                    sumaCyfr = sumaCyfr + kolejna_cyfra;
                    if (aktualny.wartosc % kolejna_cyfra != 0)
                    {
                        aktualny.czyPodzielna = false;
                    }
                }
                if (aktualny.wartosc % sumaCyfr != 0)
                {
                    aktualny.czyPodzielna = false;
                }

                if (aktualny.czyPodzielna == true)
                {
                    ListaLiczb.Add(aktualny.wartosc);
                }
            
            }
            for (int i = 0; i < ListaLiczb.Count; i++)
            {
                Console.WriteLine(ListaLiczb[i]);
            }
            Console.ReadLine();
        }
       
    }
}
