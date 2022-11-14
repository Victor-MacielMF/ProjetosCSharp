using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto1 = "Insira a sua idade.";
            Console.WriteLine(texto1);
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você já está na maioridade.");
            }
            else
            {
                Console.WriteLine("Você ainda não atingiu a maioridade.");
            }
        }
    }
}
