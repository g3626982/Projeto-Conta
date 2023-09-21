using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.Class
{
    internal class ContaCorrente : Conta
    {
        ContaCorrente(int numero, Cliente titular) : base(numero, titular) { }

        public override bool Saque(decimal valor)
        {
         if(Saldo >= valor)
            {
                Saldo -= valor; //Saldo = saldo - valor

                return true;
            }
            return false;
        }
    }
}
