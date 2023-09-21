using Conta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.Class
{
    internal class ContaPoupanca : Conta
    {
        public ContaPoupanca(int numero, Cliente Titular) : base(numero, Titular) { }
        public override bool Saque(decimal valor)
        {
           if(Saldo >= valor)
            {
                Saldo -= (valor + 0.05m);

                return true;
            }
        }
    }
}
