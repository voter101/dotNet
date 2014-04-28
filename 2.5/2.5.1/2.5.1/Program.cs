using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5._1
{
    class Program
    {
        public static void Main(string[] args)
        {
            testy sample = new testy();
            sample.test();
            sample.testD();
            Console.ReadKey();
        }
        
        
        public class testy{
            public void test()
            {
                DateTime Start = DateTime.Now;
                for (int i = 0; i <= 30000000; i++)
                {
                    Foo(234452, 234234);
                }
                DateTime End = DateTime.Now;
                TimeSpan Czas = End - Start;
                Console.WriteLine(Czas);
            }
            public void testD()
            {
                DateTime Start = DateTime.Now;
                for (int i = 0; i <= 30000000; i++)
                {
                    FooD(234452, 234234);
                }
                DateTime End = DateTime.Now;
                TimeSpan Czas = End - Start;
                Console.WriteLine(Czas);
            }
            public int Foo(int x, int y)
            {
                return ((( x * y) + y + x) * y);
            }
            public dynamic FooD(dynamic x, dynamic y)
            {
                return ((( x * y) + y + x) * y);
            }
        }
    }
}
