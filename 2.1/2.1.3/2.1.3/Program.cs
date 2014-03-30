using System;
using System.Reflection;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Klasa klasa = new Klasa(5);
            int wynik = 0;
            int LiczbaProb = 10000000;


            // metoda prywatna refleksja
            DateTime Start = DateTime.Now;
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                MethodInfo dodawanko = klasa.GetType().GetMethod("Dodaj", BindingFlags.Instance | BindingFlags.NonPublic);
                wynik = (int)dodawanko.Invoke(klasa, new object[] { (int)5, (int)6 });

            }
            Console.WriteLine(wynik);
            DateTime End = DateTime.Now;
            TimeSpan Czas = End - Start;
            Console.WriteLine(Czas);

            // wlasciwosc prywatna refleksja
            Start = DateTime.Now;
            for (int proba = 0; proba < LiczbaProb; proba++)
            {
                MethodInfo dane = klasa.GetType()
               .GetProperty("Dane", BindingFlags.NonPublic | BindingFlags.Instance).GetGetMethod(true);

                wynik = (int)dane.Invoke(klasa, null);

            }
            Console.WriteLine(wynik);
            End = DateTime.Now;
            Czas = End - Start;
            Console.WriteLine(Czas);
           
            //metoda normalnie
            klasa.testMetody(5, 6, 10000000);
            

            //wlasciwosc normlanie
            klasa.testWlasciwosci(10000000);





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
    public void testMetody(int a, int b, int LiczbaProb)
    {
        int wynik = 0;
        DateTime Start = DateTime.Now;
        for (int proba = 0; proba < LiczbaProb; proba++)
        {
            wynik = Dodaj(a,b);

        }
        Console.WriteLine(wynik);
        DateTime End = DateTime.Now;
        TimeSpan Czas = End - Start;
        Console.WriteLine(Czas);

    }
    public void testWlasciwosci(int LiczbaProb)
    {
        int wynik = 0;
        DateTime Start = DateTime.Now;
        for (int proba = 0; proba < LiczbaProb; proba++)
        {
            wynik = Dane;

        }
        Console.WriteLine(wynik);
        DateTime End = DateTime.Now;
        TimeSpan Czas = End - Start;
        Console.WriteLine(Czas);

    }
}