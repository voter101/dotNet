using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid
{
    
    /// <summary>
    ///  Klasa z Indekserem
    /// </summary>
    public class Grid
    {
        static void Main(string[] args)
        {

        }

        int[][] siatka;


        /// <summary>
        /// Metoda tworzaca sietke o zadanych parametrach
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Grid(int x, int y)
        {
            siatka = new int[x][];
            for (int i = 0; i < x; i++)
            {
                siatka[i] = new int[y];
            }
        }
        /// <summary>
        /// Indekser jedno wymiarowy ktory zwraca jeden wymiar tablicy
        /// </summary>
        /// <param name="indeks"></param>
        /// <returns></returns>
        public int[] this[int indeks]
        {
            get
            {
                return this.siatka[indeks];
            }
        }
        /// <summary>
        /// Indekser wielowymiarowy ktory zwraca konkretna wartosc 
        /// </summary>
        /// <param name="indeks"></param>
        /// <param name="indeks2"></param>
        /// <returns></returns>
        public int this[int indeks, int indeks2]
        {

            get
            {
                return this.siatka[indeks][indeks2];
            }
            set
            {
                this.siatka[indeks][indeks2] = value;
            }
        }

    }
}
