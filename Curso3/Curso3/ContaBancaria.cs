using System.Globalization;

namespace Curso3
{
    internal class ContaBancaria
    {
        
        private double _taxaSaque = 5.00;
        public string NomeTitularConta { get; set; }
        public int NumeroConta { get; private set; }
        public double SaldoConta { get; private set; }

        public ContaBancaria(int numeroConta, string nomeTitularConta)
        {
            NumeroConta = numeroConta;
            NomeTitularConta = nomeTitularConta;
        }

        public ContaBancaria(int numeroConta, string nomeTitularConta, double depositoInicial) : this (numeroConta, nomeTitularConta)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valorDeposito)
        {
            SaldoConta = valorDeposito > 0 ? SaldoConta + valorDeposito : SaldoConta;
        }

        public void Saque(double valorSaque)
        {
            if(valorSaque > 0 && valorSaque <= SaldoConta)
            {
                SaldoConta -= valorSaque + _taxaSaque;
            }
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + ", Titular: " + NomeTitularConta + ", Saldo: $ " + SaldoConta.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
