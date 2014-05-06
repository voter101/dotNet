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
            var grupy = from nazwisko in System.IO.File.ReadAllLines(@"data.txt")
                        orderby nazwisko
                        group nazwisko by nazwisko[0] into g
                        select g.Key;
            foreach (var g in grupy)
            {
                Console.WriteLine(g);
            }
            Console.ReadKey();
        }
    }
}
