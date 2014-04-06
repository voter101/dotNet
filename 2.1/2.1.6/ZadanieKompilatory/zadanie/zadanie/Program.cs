using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaKolorow mojaListaKolorow = new ListaKolorow("Moja Lista");
            for (int i = 0; i <= 10; i++)
            {
                mojaListaKolorow.dodajKolor("brak");
            }
            Console.WriteLine(mojaListaKolorow[5]);
            for (int i = 0; i <= 10; i++)
            {
                int zmienna = i % 3;
                Console.WriteLine(zmienna);
                switch (zmienna)
                {
                    case 0:
                        mojaListaKolorow[i] = "kolor zerowy";
                        break;
                    case 1:
                        if (mojaListaKolorow[i] == "brak")
                        {
                            mojaListaKolorow[i] = " kolor z pozycji pierwszej";
                        }
                        else
                        {
                            Console.WriteLine("chyba cos jest nie tak");
                        }
                        break;
                    case 2:
                        while (mojaListaKolorow[i] != "kolor z pozycji drugiej")
                        {
                            mojaListaKolorow[i] = "kolor z pozycji drugiej";
                            Console.WriteLine("Powinno byc wypisane raz");
                        }
                        break;
                }
            }
            if (mojaListaKolorow.name == "Moja Lista")
            {
                mojaListaKolorow.name = "Moja Lista Kolorow";
            }
            Console.ReadKey();
        }
    }
    class ListaKolorow
    {
        string nazwaListy;
        List<string> list;
        public string name
        {
            get
            {
                return this.nazwaListy;
            }
            set
            {
                this.nazwaListy = value;
            }
        }
        public string this[int indeks]
        {
            get
            {
                return this.list[indeks];
            }
            set
            {
                this.list[indeks] = value;
            }
        }
        public ListaKolorow(string name)
        {
            this.nazwaListy = name;
            this.list = new List<string>();
        }
        public void dodajKolor(string kolor)
        {
            this.list.Add(kolor);
        }
    }
}