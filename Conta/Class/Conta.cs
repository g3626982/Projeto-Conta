using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.Class
{
    internal abstract class Conta
    {
        public int Numero { get; private set; }
        public decimal Saldo { get; protected set; }
        public Cliente Titular { get; private set; }
        public Conta(int numero, Cliente titular)
        {
            Numero = numero;
            Titular = titular;
        }
         public decimal Deposito(decimal valor)
        {
            return Saldo += valor;//Saldo = Saldo + valor
        }

        public abstract bool  Saque(decimal valor);

        public bool Transfere(decimal valor, Conta conta)
        {
            if(Saldo >= valor)
            {
                Saldo -= conta.Deposito(valor);

                return true;
            }
            else
            {
                return false;
            }
          }
        }
    }
