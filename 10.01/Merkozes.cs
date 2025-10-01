using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._01
{
	internal class Merkozes
	{
		private Csapat hazai;
		private Csapat vendeg;
		private string helyszin;
		private DateTime idopont;

		public Merkozes(Csapat hazai, Csapat vendeg, string helyszin, DateTime idopont)
		{
			this.hazai = hazai;
			this.vendeg = vendeg;
			this.helyszin = helyszin;
			this.idopont = idopont;
		}

		public string Helyszin { get => helyszin;}
		public DateTime Idopont { get => idopont;}
		internal Csapat Hazai { get => hazai;}
		internal Csapat Vendeg { get => vendeg;}

		public override string ToString()
		{
			return $"{this.hazai} - {this.vendeg} {this.idopont} {this.helyszin}";
		}
	}
}
