using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> Funcionarios = new List<Funcionario>();

            Console.Write("Informe a quantidade de funcionários que serão registrados: ");
            int QuantidadeFuncionarios = int.Parse(Console.ReadLine());

            for (int i = 0; i < QuantidadeFuncionarios; i++)
            {
                Console.WriteLine("Funcionário #{0}", i + 1);
                Console.Write("Id: ");
                int Id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string Nome = Console.ReadLine();
                Console.Write("Salário: ");
                double Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                Funcionarios.Add(new Funcionario(Id, Nome, Salario));
            }

            Console.Write("Entre com o id do funcionário que receberá um aumento: ");
            int IdAumento = int.Parse(Console.ReadLine());

            Funcionario Funcionario = Funcionarios.Find(x => x.Id == IdAumento);
            if (Funcionario != null)
            {
                Console.Write("Entre com a porcentagem do aumento: ");
                double Porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Funcionario.AumentoSalarial(Porcentagem);
            }
            else
            {
                Console.WriteLine("Este ID não existe!");
            }

            Console.WriteLine("\nLista atualizada de funcionários: ");
            foreach (Funcionario Func in Funcionarios)
            {
                Console.WriteLine(Func);
            }
        }

    }
}