using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid grid = new Grid(10, 10);

            int[] dupa = grid[9];
            Console.WriteLine(dupa[4]);
            grid[9, 4] = 4;
            int elem = grid[1, 4];
            int elemm = grid[3, 5];
            Console.WriteLine(elem);
            Console.WriteLine(elemm);
            int[] dupaa = grid[9];
            Console.WriteLine(dupaa[4]);
            Console.ReadLine();
        }
    }
}
