using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Set set = new Set();
            set.Add(5);
            set.Add(6);
            set.Add(true);
            set.Add(true);
            set.Add("sample");
            set.Add("sample");
            set.Add(6);

            foreach (object liczba in set)
                Console.WriteLine(liczba);

            Console.ReadKey();
        }
    }
}
