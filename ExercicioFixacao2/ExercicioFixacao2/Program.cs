using System;

namespace ExercicioFixacao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0, b = -3.0, c = -4.0;


            double Baskara1 = (-b + Math.Sqrt(Math.Pow(b, 2.0) - 4.0 * a * c)) / (2.0 * a);
            double Baskara2 = (-b - Math.Sqrt(Math.Pow(b, 2.0) - 4.0 * a * c)) / (2.0 * a);

            Console.WriteLine("x1 = {0}\nx2 = {1}", Baskara1, Baskara2);
        }
    }
}