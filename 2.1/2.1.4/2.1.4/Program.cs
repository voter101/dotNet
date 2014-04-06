using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void ListMethods(object obj)
        {
            var methods = obj.GetType().GetMethods();
            foreach (var methodInfo in methods)
            {
                if (methodInfo.IsPublic && !methodInfo.IsStatic && methodInfo.ReturnType == typeof(int) &&
                    methodInfo.GetParameters().Length == 0)
                {
                    if (methodInfo.GetCustomAttributes(typeof(OznakowaneAttribute), false).Length > 0)
                        Console.WriteLine(methodInfo.Name);
                }
            }
        }

        static void Main(string[] args)
        {
            ListMethods(new Klasa(5));

            Console.ReadKey();
        }
    }
}

class Klasa
{
    public Klasa(int d)
    {
        Dane = d;
    }

    private int Dane { get; set; }

    private int Dodaj(int a, int b)
    {
        return a + b;
    }

    private int Pięć()
    {
        return 5;
    }

    public int Foo()
    {
        return 5;
    }

    [Oznakowane]
    public int Bar()
    {
        return 6;
    }
}

class OznakowaneAttribute : Attribute
{
}