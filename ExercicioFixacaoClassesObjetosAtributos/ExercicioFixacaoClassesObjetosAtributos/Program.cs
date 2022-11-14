using System;
using System.Globalization;

namespace ClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.Write("Dados do primeiro funcionário:\nNome: ");
            funcionario1._nome = Console.ReadLine();
            Console.Write("Idade: ");
            funcionario1._salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.Write("Dados do segundo funcionário:\nNome: ");
            funcionario2._nome = Console.ReadLine();
            Console.Write("Idade: ");
            funcionario2._salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Salário médio = {0}", ((funcionario1._salario+funcionario2._salario)/2).ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    class Funcionario
    {
        public string _nome;
        public double _salario;
    }
}