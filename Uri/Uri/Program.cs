using System;
using System.Globalization;

namespace Consumo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            float combustivel = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine( (km/combustivel).ToString("F3",CultureInfo.InvariantCulture) + "km/l");;
        }
    }
}