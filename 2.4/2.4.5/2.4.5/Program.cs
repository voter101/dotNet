using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var dane = System.IO.File.ReadAllLines(@"Dane.txt");
            var nrKont = System.IO.File.ReadAllLines(@"nrKont.txt");
            var listaDanych = from line in dane
                              select new { imie = line.Split(',')[0], nazwisko = line.Split(',')[1], PESEL = line.Split(',')[2] };
            var listaKont = from line in nrKont
                            select new { PESEL = line.Split(',')[0], nrKonta = line.Split(',')[1]};

            var BazaZNumeramiKont = from dana in listaDanych
                                    join nrKonta in listaKont
                                    on dana.PESEL equals nrKonta.PESEL
                                    select new
                                    {
                                        imie = dana.imie,
                                        nazwisko = dana.nazwisko,
                                        PESEL = dana.PESEL,
                                        nrKonta = nrKonta.nrKonta
                                    };

            foreach (var rekord in BazaZNumeramiKont)
            {
                Console.WriteLine("{0} {1} PESEL: {3} numer konta: {2}", rekord.imie, rekord.nazwisko, rekord.nrKonta, rekord.PESEL);
            }
            Console.ReadKey();
        }
    }
}
