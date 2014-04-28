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

            var listaLogow = from log in logi
                             let poszatkowanyLog = log.Split(' ')
                             select new { CZAS = poszatkowanyLog[0], IP = poszatkowanyLog[1], TYP = poszatkowanyLog[2], ZASOB = poszatkowanyLog[3], STATUS = poszatkowanyLog[4] };

            var listaIp = from log in listaLogow
                          group log by log.IP into g
                          select new { IP = g.Key, listaLogow = g };

            var maxIp = from ip in listaIp
                        orderby ip.listaLogow.Count() descending
                        select ip;
            var wynik = maxIp.Take(3);

            foreach (var ip in wynik)
            {
                Console.WriteLine("{0}, {1}", ip.IP, ip.listaLogow.Count());
            }
            Console.ReadKey();
        }
    }
}
