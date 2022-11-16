﻿using System;
using System.Globalization;
using ProjetosCentralizados.Entities;
using ProjetosCentralizados.Entities.Enums;

namespace ProjetosCentralizados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string InputNameClient = Console.ReadLine();
            Console.Write("Email: ");
            string InputEmailClient = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime InputBirthClient = DateTime.Parse(Console.ReadLine());
            Aula132_Client Client = new Aula132_Client(InputNameClient, InputEmailClient, InputBirthClient);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            Aula132_OrderStatus InputOrderStatus = Enum.Parse<Aula132_OrderStatus>(Console.ReadLine());
            Aula132_Order Order = new Aula132_Order(InputOrderStatus, Client);

            Console.Write("How many items to this order? ");
            int InputOrderQuantity = int.Parse(Console.ReadLine());
            for (int i = 0; i < InputOrderQuantity; i++)
            {
                Console.WriteLine("Enter #{0} item data:", i + 1);
                Console.Write("Product name: ");
                string InputProductName = Console.ReadLine();
                Console.Write("Product price: ");
                double InputProductPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int InputProductQuantity = int.Parse(Console.ReadLine());

                Aula132_Product Product = new Aula132_Product(InputProductName, InputProductPrice);
                Aula132_OrderItem OrderItem = new Aula132_OrderItem(InputProductQuantity, Product);

                Order.AddItem(OrderItem);
            }

            Console.WriteLine("\n" + Order);
        }
    }
}
/*

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
            Aula128_Departament Departament = new Aula128_Departament(InputNameDepartament);

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string InputNameWorker = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            Aula128_WorkerLevel InputLevelWorker = Enum.Parse<Aula128_WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double InputSalaryWorker = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Aula128_Worker Worker = new Aula128_Worker(InputNameWorker, InputLevelWorker, InputSalaryWorker, Departament);

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

                Aula128_HourContract Contract = new Aula128_HourContract(InputDateContract, InputValueHourContract, InputDurationContract);

                Worker.Contracts.Add(Contract);
            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            DateTime InputDateIncome = DateTime.Parse(Console.ReadLine());

            string SalaryWorkerTotal = Worker.Income(InputDateIncome.Year, InputDateIncome.Month).ToString("F2", CultureInfo.InvariantCulture);

            Console.Write("{0}\nIncome for {1}: {2}", Worker, InputDateIncome.ToString("MM/yyyy"), SalaryWorkerTotal);
        }
    }
}
*/