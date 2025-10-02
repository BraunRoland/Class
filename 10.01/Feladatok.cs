using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace _10._01
{
	internal class Feladatok
	{
		private List<Merkozes> lista;

		public Feladatok()
		{
			lista = new List<Merkozes>();
			Beolvas("eredmenyek.csv");
		}
		internal List<Merkozes> Lista { get => lista; set => lista = value; }

		private void Beolvas(string fajlnev)
		{
			StreamReader sr = new StreamReader(fajlnev);
			sr.ReadLine();
			while (!sr.EndOfStream)
			{
				string[] adat = sr.ReadLine().Split(';');
				Csapat hazai = new Csapat(adat[0], int.Parse(adat[2]));
				Csapat vendeg = new Csapat(adat[1], int.Parse(adat[3]));
				string helyszin = adat[4];
				DateTime idopont = Convert.ToDateTime(adat[5]);
				lista.Add(new Merkozes(hazai, vendeg, helyszin, idopont));
			}
		}

		public string F3()
		{
			string s = "";
            int hazaiSz = 0;
			int vendegSz = 0;

			s += $"3. feladat: Real Madrid mérkőzései:\n";
			foreach (Merkozes item in lista)
			{
				if (item.Hazai.Nev.Equals("Real Madrid"))
				{
					hazaiSz++;
				}
				else if (item.Vendeg.Nev.Equals("Real Madrid"))
				{
					vendegSz++;
				}
			}
			s += $"\tHazai: {hazaiSz}\n\tVendég: {vendegSz}\n";
			Trace.WriteLine(s);
			return s;
        }

		public string F4()
		{
			int i = 0;
			string s = "";
			while (i< lista.Count && lista[i].Hazai.Pontszam != lista[i].Vendeg.Pontszam)
			{
				i++;
			}
			if ( i < lista.Count)
			{
				s = "igen";
			}
			else
			{
				s = "nem";
			}
				return $"4. feladat: Volt döntetlen? {s}\n";
		}

		public string F5()
		{
			int i = 0;
			string s = "";

			foreach ( Merkozes item in lista)
			{
				if (item.Hazai.Nev.Contains("Barcelona"))
				{
					s = item.Hazai.Nev;
					break;
				}
			}
			return $"5. feladat: barcelonai csapat teljes neve:\n\t{s}\n";
		}

		public string F6()
		{
			DateTime datum = new DateTime(2004, 11, 21);
			string s = "6. feladat:";
			foreach (Merkozes item in lista)
			{
				if (item.Idopont.Date == datum)
				{
					s += $"\n\t{item.Hazai.Nev} - {item.Vendeg.Nev}, {item.Helyszin} ({item.Hazai.Pontszam}:{item.Vendeg.Pontszam})";
				}
			}
			return s;
		}

		public string F7()
		{
			string s = "7. feladat: ";
			List<string> helyszinek = new List<string>();
            foreach (Merkozes item in lista)
			{
				helyszinek.Add(item.Helyszin);
            }
			helyszinek = helyszinek.Distinct().ToList();
			foreach(string item in helyszinek)
            {
				int merkozesekSzama = 0;
				foreach (Merkozes m in lista)
                {
                    if (m.Helyszin.Equals(item))
                    {
                        merkozesekSzama++;
                    }
                }
				if (merkozesekSzama > 20)
				{
					s += $"\n\t{item}: {merkozesekSzama}";
					Trace.WriteLine($"{item}: {merkozesekSzama}");
				}
            }
            return s;
		}
	}
}
