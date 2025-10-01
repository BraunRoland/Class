using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._01
{
	internal class Csapat
	{
		private string nev;
		private int pontszam;

		public Csapat(string nev, int pontszam)
		{
			this.nev = nev;
			this.pontszam = pontszam;
		}

		public string Nev { get => nev;}
		public int Pontszam { get => pontszam;}

		public override string ToString()
		{
			return $"{this.nev} {this.pontszam}";
		}
	}
}
