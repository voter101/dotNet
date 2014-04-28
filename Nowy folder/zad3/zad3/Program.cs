using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad3
{
    class Program
    {
        private delegate void TypDelegacji();

        public static void Main(string[] args)
        {
            List<int> sample = new List<int>(){4,5,8,2,3,9,15,1,13,2};
            
            //obiektDelegacji(sample);
            TypDelegacji obiektDelegacji2 = new TypDelegacji(Sort());
            obiektDelegacji2();            
            foreach (int item in sample)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

    }
}
