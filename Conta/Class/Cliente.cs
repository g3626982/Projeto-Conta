using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.Class
{
    internal class Cliente
    {
        public string Nome { get; private set; }

        public string CPF { get; private set; }

        public Cliente(string nome, string cpf)
        {

            Nome = nome;
            CPF = cpf;

        }
    }
}
