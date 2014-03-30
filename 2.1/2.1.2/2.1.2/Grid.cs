using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2
{
    class Grid
    {
        int[][] siatka;



        public Grid(int x, int y)
        {
            siatka = new int[x][];
            for (int i = 0; i < x; i++)
            {
                siatka[i] = new int[y];
            }
        } 
        public int[] this[int indeks]
        {
            get
            {
                return this.siatka[indeks];
            }
        }
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
