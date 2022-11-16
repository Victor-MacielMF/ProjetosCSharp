//Exercicio - Aula 128

using System;
using System.Globalization;
using ProjetosCentralizados.Entities;
using ProjetosCentralizados.Entities.Enums;

namespace ProjetosCentralizados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string InputNameDepartament = Console.ReadLine();
            Departament Departament = new Departament(InputNameDepartament);

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string InputNameWorker = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel InputLevelWorker = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double InputSalaryWorker = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Worker Worker = new Worker(InputNameWorker, InputLevelWorker, InputSalaryWorker, Departament);

            Console.Write("How many contracts to this worker? ");
            int QuantityContracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < QuantityContracts; i++)
            {
                Console.WriteLine("Enter #{0} contract data", i + 1);
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime InputDateContract = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double InputValueHourContract = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int InputDurationContract = int.Parse(Console.ReadLine());

                HourContract Contract = new HourContract(InputDateContract, InputValueHourContract, InputDurationContract);

                Worker.Contracts.Add(Contract);
            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            DateTime InputDateIncome = DateTime.Parse(Console.ReadLine());

            string SalaryWorkerTotal = Worker.Income(InputDateIncome.Year, InputDateIncome.Month).ToString("F2", CultureInfo.InvariantCulture);

            Console.Write("{0}\nIncome for {1}: {2}", Worker, InputDateIncome.ToString("MM/yyyy"), SalaryWorkerTotal);
        }
    }
}