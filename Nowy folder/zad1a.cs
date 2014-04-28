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
            int LiczbaProb = 30000000;
            
            
            ArrayList arrayList = new ArrayList();
            List<string> listT = new List<string>();
            Hashtable hashTable = new Hashtable();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            
            
            
            Console.WriteLine("ArrayList vs List<T>: \n");
            DateTime ArrayStart = DateTime.Now;
            Console.WriteLine("ArrayList: ");
            string test;
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                arrayList.Add("1");
            }
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                test = (string)arrayList[proba];
            }
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                arrayList.RemoveAt(arrayList.Count - 1);
            }
            DateTime ArrayEnd = DateTime.Now;
            TimeSpan ArrayCzas = ArrayEnd - ArrayStart;
            Console.WriteLine(ArrayCzas);


            DateTime ListStart = DateTime.Now;
            Console.WriteLine("ListT: ");
            string test1;
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                listT.Add("1");
            }
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                test1 = listT[proba];
            }
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                listT.RemoveAt(listT.Count - 1);
            }
            DateTime ListEnd = DateTime.Now;
            TimeSpan ListCzas = ListEnd - ListStart;
            Console.WriteLine(ListCzas);





            int LiczbaProbSlownikow = 1000000; 


            Console.WriteLine("Hashtable vs Dictionary: \n");
            DateTime hashStart = DateTime.Now;
            Console.WriteLine("Hashtable: ");
            string test2;
            for (int proba = 0; proba < LiczbaProbSlownikow; proba++)
            {
                hashTable.Add(proba, "a");
            }
            for (int proba = 0; proba < LiczbaProbSlownikow; proba++)
            {
                test2 = (string)hashTable[proba];
            }
            for (int proba = 0; proba < LiczbaProbSlownikow; proba++)
            {
                hashTable.Remove(proba); ;
            }
            DateTime hashEnd = DateTime.Now;
            TimeSpan hashCzas = hashEnd - hashStart;
            Console.WriteLine(hashCzas);

            
            DateTime dictionaryStart = DateTime.Now;
            Console.WriteLine("Dictionary: ");
            string test3;
            for (int proba = 0; proba < LiczbaProbSlownikow; proba++)
            {
                dictionary.Add(proba, "a");
            }
            for (int proba = 0; proba < LiczbaProbSlownikow; proba++)
            {
                test3 = dictionary[proba];
            }
            for (int proba = 0; proba < LiczbaProbSlownikow; proba++)
            {
                dictionary.Remove(proba);
            }
            DateTime dictionaryEnd = DateTime.Now;
            TimeSpan dictionaryCzas = dictionaryEnd - dictionaryStart;
            Console.WriteLine(dictionaryCzas);


            Console.ReadKey();
        }
    }
}
