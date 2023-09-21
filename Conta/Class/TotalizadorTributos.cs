using Conta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.Class
{
    internal class TotalizadorTributos
    {
        public decimal Total { get; private set; }
        public decimal Soma(ITributavel tributavel)
        {
            return Total += tributavel.CalculoTributo();
        }
    }
}
