using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Comercial_IBM
{
    public class Cliente
    {
        public int Idade;
        public Cliente(string _nome)
        {
            this.Nome = _nome;
        }
        public string Nome { get; set; }
    }
}
