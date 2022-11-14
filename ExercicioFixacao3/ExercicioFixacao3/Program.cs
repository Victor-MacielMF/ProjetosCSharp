using System;
using System.Diagnostics;
using System.Globalization;

namespace ExercicioFixacao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] vetor = Console.ReadLine().Split(' ');


            Console.WriteLine("{0}\n{1}", nome, quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("{0}\n{1}\n{2}", vetor[0], vetor[1], vetor[2]);
        }
    }
}