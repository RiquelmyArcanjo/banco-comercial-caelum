using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco_Comercial_IBM.Interfaces;

namespace Banco_Comercial_IBM
{
	public class TotalizadorDeTributos
	{
		public double Total { get; private set; }
        public void Acumula(ITributavel t)
        {
            this.Total += t.CalcularTributos();
        }
    }
}
