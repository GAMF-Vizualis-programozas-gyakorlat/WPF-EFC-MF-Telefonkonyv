using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonkonyv
{
	public partial class Szemely
	{
		public string? HelységNév => Helység?.Név;
		public int? HelységIrányítószám => Helység?.Irányítószám;
		public string TelefonszámLista => Számok.Aggregate("",
			(c, a) => c + (c.Length > 0 ? ", " : "") + a.SzámSztring);
	}
}