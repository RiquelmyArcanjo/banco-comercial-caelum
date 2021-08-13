using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Comercial_IBM
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }
        //atributo apenas da classe
        private static int NumeroContas;

        public Conta()
        {
            Conta.NumeroContas++;
            this.Numero = Conta.NumeroContas;
        }


        public abstract void Sacar(double valor);

        public abstract void Depositar(double valor);


        public virtual void Transferir(double valor, Conta contaDestino)
        {
            if (valor <= 0.0)
                throw new ArgumentException("O Valor para transferência deve ser maior que zero.");
            if (Saldo < valor)
                throw new ArgumentException("Saldo insuficiente para realizar a transferência!");

            this.Saldo -= valor;
            contaDestino.Saldo += valor;
        }

        public static int ProximoNumero()
        {
            return NumeroContas + 1;
        }
        public override string ToString()
        {
            return "Titular: " + this.Titular.Nome;
        }

    }
}
