using Conta.Class;
using System.Net.Http.Headers;

namespace Conta
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cliente gabriel = new Cliente("Gabriel","12345678900");
            Cliente paulo = new Cliente("Paulo", "1261168454566");

            ContaCorrente ccGabriel = new ContaCorrente(1357, gabriel);
            ContaInvestimento ciGabriel = new ContaInvestimento(2468, gabriel);
            ContaPoupanca cpGabriel = new ContaPoupanca(3691, gabriel);

            ContaCorrente ccPaulo = new ContaCorrente(7891, paulo);

            ccGabriel.Deposito(6000);
            ciGabriel.Deposito(1000);
            cpGabriel.Deposito(1000);


           ciGabriel.Transfere(200, ccPaulo);

           if (cpGabriel.Saque(50)) ;
            {
                Console.WriteLine("Saque Efetuado com sucesso!!");
            }

            Console.WriteLine($"Saldo Conta Corrente Gabriel: {ccGabriel.Saldo}");
            Console.WriteLine($"Saldo Conta Investimento Gabriel: {ciGabriel.Saldo}");
            Console.WriteLine($"Saldo Conta Poupança Gabriel: {cpGabriel.Saldo}");
            Console.WriteLine($"Saldo Conta Corrente Gabriel: {ccPaulo.Saldo}");

            TotalizadorContas totalContas = new TotalizadorContas();

            totalContas.Soma(ccGabriel);
            totalContas.Soma(ciGabriel);
            totalContas.Soma(cpGabriel);
            totalContas.Soma(ccPaulo);

            Console.WriteLine($"Total de dinheiro em todas as contas: {totalContas.Total}");

            TotalizadorTributos totalizadorTributos = new TotalizadorTributos();

            totalizadorTributos.Soma(ciGabriel);
            totalizadorTributos.Soma(cpGabriel);

            Console.WriteLine($"total de tributos pagos das contas de investimento e poupança: {totalizadorTributos.Total:c}");


        }
    }
}