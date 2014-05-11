using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace _3._1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime();
            data = DateTime.Now;

            List<CultureInfo> listaJezykow = new List<CultureInfo>();
            listaJezykow.Add(new CultureInfo("en"));
            listaJezykow.Add(new CultureInfo("de"));
            listaJezykow.Add(new CultureInfo("fr"));
            listaJezykow.Add(new CultureInfo("ru"));
            listaJezykow.Add(new CultureInfo("ar"));
            listaJezykow.Add(new CultureInfo("cs"));
            listaJezykow.Add(new CultureInfo("pl"));

            foreach (CultureInfo jezyk in listaJezykow)
            {
                Console.WriteLine("{0} \n Pełna nazwa Miesięcy: ", jezyk.EnglishName);
                foreach (string miesiac in jezyk.DateTimeFormat.MonthNames)
                {
                    Console.WriteLine(miesiac);
                }
                Console.WriteLine("\nSkrótowa nazwa Miesięcy: ");
                foreach (string miesiac in jezyk.DateTimeFormat.AbbreviatedMonthNames)
                {
                    Console.WriteLine(miesiac);
                }
                Console.WriteLine("\nPełna nazwa Dni: ");
                foreach (string dzien in jezyk.DateTimeFormat.DayNames)
                {
                    Console.WriteLine(dzien);
                }
                Console.WriteLine("\nSkrótowe nazwy dni:");
                foreach (string miesiac in jezyk.DateTimeFormat.AbbreviatedDayNames)
                {
                    Console.WriteLine(miesiac);
                }
                Console.WriteLine("\n{0}", data.ToString("D", jezyk));
                Console.WriteLine();

            }

           

            Console.ReadKey();
        }
    }
}
