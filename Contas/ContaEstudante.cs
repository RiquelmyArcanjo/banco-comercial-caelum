using Banco_Comercial_IBM.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Comercial_IBM
{
    class ContaEstudante : Conta
    {
        public override void Sacar(double valor)
        {
            if (valor <= 0.0)
                throw new ArgumentException("O Valor de saque deve ser maior que zero.");
            if (Saldo < valor)
                throw new SaldoInsuficienteException("A retirada é maior que o saldo da conta.");

            this.Saldo -= valor;
        }
        public override void Depositar(double valor)
        {
            if (valor <= 0.0)
                throw new ArgumentException("O Valor de depósito deve ser maior que zero.");
            if (valor > 5000)
                throw new LimiteDepositoException("O limite de depósito nos caixas eletrônicos é de R$ 5.000,00. Realize outro depósito ou compareça ao guichê de atendimento!");

            valor += (valor * 0.1);
            this.Saldo += valor;
        }
    }
}
