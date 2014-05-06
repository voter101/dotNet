using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            var logi = System.IO.File.ReadAllLines(@"logi.txt");

            var ips = from log in logi
                             let poszatkowanyLog = log.Split(' ')
                             group poszatkowanyLog by poszatkowanyLog[1] into a
                             orderby a.Count() descending
                             select new { ip = a.Key, count = a.Count() };

            var wynik = ips.Take(3);

            foreach (var ip in wynik)
            {
                Console.WriteLine("{0}, {1}", ip.ip, ip.count);
            }
            Console.ReadKey();
        }
    }
}
