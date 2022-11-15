using System;
using Aula124.Entities;
using Aula124.Entities.Enums;

namespace Aula124
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order Pedido = new Order(1, DateTime.Now, OrderStatus.Delivered);

            Console.WriteLine(Pedido);
        }
    }
}