using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.Class
{
    internal class TotalizadorContas
    {
        public decimal Total { get; private set; }
        public void Soma(Conta conta)
        {
             Total += conta.Saldo;

        }
    }
}
