using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace _2._1._4
{
    class Program
    {
        static void PrintTypeInfo(Type t)
        {
            Console.WriteLine("Definicja {0} znajduje sie w  module {1}.", t, t.Module);
        } 
        static void Main(string[] args)
        {
            string s = String.Empty;
            PrintTypeInfo(s.GetType());

            Type t = Type.GetType("_2._1._4.Program");
            PrintTypeInfo(t);
            Console.ReadLine();
        }

    }


    public class Oznakowane : Attribute
    {
    }
    public class HelloWorld
    {
        [Oznakowane]
        public int bar()
        {
            return 1;
        }

        public int Qux()
        {
            return 2;
        }
    }
}
