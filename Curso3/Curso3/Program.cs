using System;
using System.Globalization;

namespace Curso3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria Conta;

            Console.Write("Entre o número da conta: ");
            int NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string NomeTitularConta = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string OpcaoDepositoInicial = Console.ReadLine();

            while (OpcaoDepositoInicial != "s" && OpcaoDepositoInicial != "n")
            {
                Console.Write("Por favor, digite 's' ou 'n'.\nHaverá depósito inicial (s/n)? ");
                OpcaoDepositoInicial = Console.ReadLine();
            };


            if (OpcaoDepositoInicial == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double DepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Conta = new ContaBancaria(NumeroConta, NomeTitularConta, DepositoInicial);
                Procedimento(Conta);
            }
            else if (OpcaoDepositoInicial == "n")
            {
                Conta = new ContaBancaria(NumeroConta, NomeTitularConta);
                Procedimento(Conta);
            }
        }

        static public void Procedimento(ContaBancaria conta)
        {
            Console.WriteLine("\nDados da conta:\n{0}\n", conta);

            Console.Write("Entre um valor para o depósito: ");
            double Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(Deposito);
            Console.WriteLine("Dados da conta atualizados:\n{0}\n", conta);

            Console.Write("Entre um valor para o saque: ");
            double Saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(Saque);
            Console.WriteLine("Dados da conta atualizados:\n{0}\n", conta);
        }
    }
}