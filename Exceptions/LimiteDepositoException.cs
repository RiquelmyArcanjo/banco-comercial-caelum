using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Comercial_IBM.Exceptions
{
    class LimiteDepositoException : Exception
    {
        public LimiteDepositoException(string message) : base(message) { }
    }
}
