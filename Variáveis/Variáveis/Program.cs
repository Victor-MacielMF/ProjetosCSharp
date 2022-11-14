using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variáveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inteiro = 1;
            char caracter = 'A';
            string texto = "apresentação deste texto é nota";
            
            //Double ocupa mais espaço na memória
            double Flutuante = 1.50;

            bool condicional = true;

            Console.WriteLine(caracter + " " + texto + " " + (11.5 - Flutuante).ToString() + ".");

        }
    }
}
