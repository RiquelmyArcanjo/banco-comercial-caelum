using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco_Comercial_IBM.Interfaces;

namespace Banco_Comercial_IBM
{
    class SeguroDeVida : ITributavel
    {
        public double CalcularTributos()
        {
            return 42;
        }
    }
}
