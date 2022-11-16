//Aula 142

using System.Globalization;
using ProjetosCentralizados.Entities;

namespace ProjetosCentralizados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int InputQuantityProducts = int.Parse(Console.ReadLine());

            List<Aula142_Product> ProductsList = new List<Aula142_Product>();

            for (int i = 0; i < InputQuantityProducts; i++)
            {
                Console.WriteLine("Product #{0} data:", i+1);
                Console.Write("Common, used or imported (c/u/i)? ");
                char InputTypeProduct = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string InputNameProduct = Console.ReadLine();
                Console.Write("Price: ");
                double InputPriceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (InputTypeProduct == 'c')
                {
                    Aula142_Product CommonProduct = new Aula142_Product(InputNameProduct, InputPriceProduct);
                    ProductsList.Add(CommonProduct);
                }
                else if (InputTypeProduct == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime InputManufactureDate = DateTime.Parse(Console.ReadLine());
                    Aula142_UsedProduct UsedProduct = new Aula142_UsedProduct(InputNameProduct, InputPriceProduct, InputManufactureDate);
                    ProductsList.Add(UsedProduct);
                }
                else if (InputTypeProduct == 'i')
                {
                    Console.Write("Customs fee: ");
                    double InputCustomsProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Aula142_ImportedProduct ImportedProduct = new Aula142_ImportedProduct(InputNameProduct, InputPriceProduct, InputCustomsProduct);
                    ProductsList.Add(ImportedProduct);
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach (Aula142_Product product in ProductsList)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}

/*
//Aula 140

using System;
using System.Globalization;
using ProjetosCentralizados.Entities;

namespace ProjetosCentralizados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int InputQuantityEmployees = int.Parse(Console.ReadLine());

            List<Aula140_Employee> EmployeeList = new List<Aula140_Employee>();

            for (int i = 0; i < InputQuantityEmployees; i++)
            {
                Console.WriteLine("Employee #{0} data: ", i + 1);
                Console.Write("Outsourced (y/n)? ");
                char InputTypeEmployee = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string InputNameEmployee = Console.ReadLine();
                Console.Write("Hours: ");
                int InputHoursEmployee = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double InputValueHourEmployee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (InputTypeEmployee == 'y')
                {
                    Console.Write("Additional charge: ");
                    double InputAdditionalEmployee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Aula140_OutsourcedEmployee OutsourcedEmployee = new Aula140_OutsourcedEmployee(InputNameEmployee, InputHoursEmployee, InputValueHourEmployee, InputAdditionalEmployee);
                    EmployeeList.Add(OutsourcedEmployee);
                }
                else if (InputTypeEmployee == 'n')
                {
                    Aula140_Employee InternalEmployee = new Aula140_Employee(InputNameEmployee, InputHoursEmployee, InputValueHourEmployee);
                    EmployeeList.Add(InternalEmployee);
                }
                else
                {
                    Console.WriteLine("Ooops, ocorreu um imprevisto.");
                    break;
                }
            }

            Console.WriteLine("\nPAYMENTS: ");
            foreach (Aula140_Employee Employee in EmployeeList)
            {
                Console.WriteLine(Employee);
            }
        }
    }
}


// Aula 138

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