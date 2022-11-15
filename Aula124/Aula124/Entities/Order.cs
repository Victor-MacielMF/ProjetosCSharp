using System;
using Aula124.Entities.Enums;

namespace Aula124.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public Order(int id, DateTime moment, OrderStatus status)
        {
            Id = id;
            Moment = moment;
            Status = status;
        }

        public override string ToString()
        {
            return "Id: " + Id + "\n" +
                "Data: " + Moment + "\n" +
                "Status: " + Status;
        }
    }
}
