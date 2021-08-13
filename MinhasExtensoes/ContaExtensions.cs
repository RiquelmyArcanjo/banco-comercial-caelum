using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Comercial_IBM.MinhasExtensoes
{
	public static class ContaExtensions
	{
		//extension method
		public static void MudaTitular(this Conta conta, Cliente titular)
		{
			conta.Titular = titular;
		}
	}

}
