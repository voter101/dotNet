using System;
namespace zadanie
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			ListaKolorow listaKolorow = new ListaKolorow("Moja Lista");
			for (int i = 0; i <= 10; i++)
			{
				listaKolorow.dodajKolor("brak");
			}
			Console.WriteLine(listaKolorow[5]);
			for (int i = 0; i <= 10; i++)
			{
				int value = i % 3;
				Console.WriteLine(value);
				switch (value)
				{
				case 0:
					listaKolorow[i] = "kolor zerowy";
					break;
				case 1:
					if (listaKolorow[i] == "brak")
					{
						listaKolorow[i] = " kolor z pozycji pierwszej";
					}
					else
					{
						Console.WriteLine("chyba cos jest nie tak");
					}
					break;
				case 2:
					while (listaKolorow[i] != "kolor z pozycji drugiej")
					{
						listaKolorow[i] = "kolor z pozycji drugiej";
						Console.WriteLine("Powinno byc wypisane raz");
					}
					break;
				}
			}
			if (listaKolorow.name == "Moja Lista")
			{
				listaKolorow.name = "Moja Lista Kolorow";
			}
			Console.ReadKey();
		}
	}
}
