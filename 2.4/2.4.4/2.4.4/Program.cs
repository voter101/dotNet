using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filePaths = System.IO.Directory.GetFiles("sample", "*.*",
                                                               System.IO.SearchOption.AllDirectories);

            var files = from path in filePaths
                        let file = new System.IO.FileInfo(path)
                        select file.Length;


            var fileTotals = files.Aggregate((current, next) => current + next);

            Console.WriteLine(fileTotals);

            Console.ReadKey();
        }
    }
}
