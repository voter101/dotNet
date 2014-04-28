using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int LiczbaProb = 50000000;
            
            
            ArrayList arrayList = new ArrayList();
            List<string> listT = new List<string>();
            Hashtable hashTable = new Hashtable();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            
            
            
            Console.WriteLine("ArrayList vs List<T>: \n");
            DateTime Start = DateTime.Now;
            Console.WriteLine("Dodawanie elementow: ");
            Console.WriteLine("ArrayList: ");
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                arrayList.Add("1");
            }
            DateTime EndArrayAdd = DateTime.Now;
            TimeSpan Czas = EndArrayAdd - Start;
            Console.WriteLine(Czas);
            Start = DateTime.Now;
            Console.WriteLine("List<T>: ");
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                listT.Add("1");
            }
            DateTime EndListT = DateTime.Now;
            Czas = EndListT - Start;
            Console.WriteLine(Czas);
            Console.WriteLine("Przegladanie: ");
            Console.WriteLine("ArrayList: ");
            string a;
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                a = (string)arrayList[proba];
            }
            DateTime EndArrayAdd2 = DateTime.Now;
            Czas = EndArrayAdd2 - EndListT;
            Console.WriteLine(Czas);
            Console.WriteLine("List<T>: ");
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                a = listT[proba];
            }
            DateTime EndListT2 = DateTime.Now;
            Czas = EndListT2 - EndArrayAdd2;
            Console.WriteLine(Czas);
            Console.WriteLine("Usuwanie: ");
            Console.WriteLine("ArrayList: ");
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                arrayList.RemoveAt(arrayList.Count - 1);
            }
            EndArrayAdd = DateTime.Now;
            Czas = EndArrayAdd - EndListT2;
            Console.WriteLine(Czas);
            Console.WriteLine("List<T>: ");
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                listT.RemoveAt(listT.Count-1);
            }
            EndListT = DateTime.Now;
            Czas = EndListT - EndArrayAdd;
            Console.WriteLine(Czas);





            LiczbaProb = 6000000;

            Console.WriteLine("Hashtable vs Dictionary: \n");
            Start = DateTime.Now;
            Console.WriteLine("Dodawanie elementow: ");
            Console.WriteLine("Hashtable: ");
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                hashTable.Add(proba, "a");
            }
            EndArrayAdd = DateTime.Now;
            Czas = EndArrayAdd - Start;
            Console.WriteLine(Czas);
            Console.WriteLine("Dictionary: ");
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                dictionary.Add(proba, "a");
            }
            EndListT = DateTime.Now;
            Czas = EndListT - EndArrayAdd;
            Console.WriteLine(Czas);
            Console.WriteLine("Przegladanie: ");
            Console.WriteLine("Hashtable: ");
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                a = (string)hashTable[proba];
            }
            EndArrayAdd2 = DateTime.Now;
            Czas = EndArrayAdd2 - EndListT;
            Console.WriteLine(Czas);
            Console.WriteLine("Dictionary: ");
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                a = dictionary[proba];
            }
            EndListT2 = DateTime.Now;
            Czas = EndListT2 - EndArrayAdd2;
            Console.WriteLine(Czas);
            Console.WriteLine("Usuwanie: ");
            Console.WriteLine("Hashtable: ");
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                hashTable.Remove(proba);
            }
            EndArrayAdd = DateTime.Now;
            Czas = EndArrayAdd - EndListT2;
            Console.WriteLine(Czas);
            Console.WriteLine("Dictionary: ");
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                dictionary.Remove(proba);
            }
            EndListT = DateTime.Now;
            Czas = EndListT - EndArrayAdd;
            Console.WriteLine(Czas);




            Console.ReadKey();
        }
    }
}
