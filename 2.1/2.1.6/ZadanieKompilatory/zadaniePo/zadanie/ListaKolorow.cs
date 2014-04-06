using System;
using System.Collections.Generic;
namespace zadanie
{
	internal class ListaKolorow
	{
		private string nazwaListy;
		private List<string> list;
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
