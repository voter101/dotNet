using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] items = File.ReadAllLines(@"data.txt");
            List<int> lista = new List<int>();
            foreach (string text in items)
            {
                int value = 0;
                Int32.TryParse(text, out value);
                lista.Add(value);
            }

            var wynik = from liczba in lista
                        where liczba <= 100
                        orderby liczba
                        select liczba;

            var temp = lista.Where(element => element <= 100).OrderBy(element => element);


            foreach (var liczba in temp)
            {
                Console.WriteLine(liczba);
            }
            Console.ReadKey();
            
            
            
            
            
            
            
            /*
            List<Person> oPersonsList = new List<Person>();
            oPersonsList.Add(new Person(1, "Jan", "Kowalski", 31, 61423423));
            oPersonsList.Add(new Person(2, "Adam", "Nowak", 28, 22126621));
            oPersonsList.Add(new Person(3, "Anna", "Kowalczyk", 30, 22532765));
            oPersonsList.Add(new Person(4, "Katarzyna", "Nowaczyk", 26, 62323545));
            oPersonsList.Add(new Person(5, "Adam", "Nowakowski", 17, 38434213));

            var oAdultPersonsList = from Person in oPersonsList
                                    orderby Person.LastName
                                    select Person;
            foreach (var person in oAdultPersonsList)
            {
                Console.WriteLine("{0} {1} ",person.FirstName, person.LastName);
            }
            
            Console.ReadKey();
        
          */}
    }
}
