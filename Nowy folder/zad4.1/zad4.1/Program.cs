using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Kobyła ma maały bok.";
            Console.WriteLine(s.isPalindrom()); 
            Console.ReadKey();
        }
    }
    public static class Rozszerzenie
    {
        public static bool isPalindrom(this string input)
        {
            string plAlfabet = "aąbcćdeęfghijklłmnńoprsśtuwyzźż";
            List<char> temp = new List<char>();
            List<char> revTemp = new List<char>();
            foreach (char x in input.ToLower()){
                if (plAlfabet.Contains(x)){
                    temp.Add(x);
                    revTemp.Insert(0, x);
                }
            }
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i] != revTemp[i])
                {
                    return false;
                }
            }
            
            return true;
            


        }

    }
}
