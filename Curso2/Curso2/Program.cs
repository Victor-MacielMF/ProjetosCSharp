using System;
using System.Globalization;
namespace Curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor a ser pago em reais = " + (ConversorDeMoeda.RealParaDolar(cotacao, qtd)).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}