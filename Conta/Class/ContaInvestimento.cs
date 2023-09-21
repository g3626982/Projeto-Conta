using Conta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.Class
{
    internal class ContaInvestimento : Conta,ITributavel
    {

        public ContaInvestimento(int numero, Cliente Titular) : base(numero, Titular) { }

        public decimal CalculoTributo()
        {
            return Saldo * 0.05m;
        }

        public override bool Saque(decimal valor)
        {
           if(Saldo >= valor)
            {
                Saldo -= (valor + 0.03m);

                return true;
            }

            return false;
        }
    }
}
