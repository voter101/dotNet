using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = System.IO.File.ReadAllLines(@"data.txt");
            var grupy = from nazwisko in list
                        orderby nazwisko
                        group nazwisko by nazwisko[0] into g
                        select new { pierwsza = g.Key};
            foreach (var g in grupy)
            {
                Console.WriteLine(g.pierwsza);
            }
            Console.ReadKey();
        }
    }
}
