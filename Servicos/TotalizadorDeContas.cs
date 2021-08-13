using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Comercial_IBM
{
    public class TotalizadorDeContas
    {
        public double SaldoTotal { get; private set; }
        public void Adiciona(Conta conta)
        {
            SaldoTotal += conta.Saldo;
        }
    }
}
