using ProjetosCentralizados.Entities.Enums;
using System.Globalization;
using System.Text;

namespace ProjetosCentralizados.Entities
{
    internal class Aula132_Order
    {
        public DateTime Moment { get; set; }
        public Aula132_OrderStatus Status { get; set;}
        public Aula132_Client Client { get; set; }
        public List<Aula132_OrderItem> OrdersItems { get; set; } = new List<Aula132_OrderItem>();

        public Aula132_Order(Aula132_OrderStatus status, Aula132_Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItem (Aula132_OrderItem item)
        {
            OrdersItems.Add(item);
        }

        public void RemoveItem(Aula132_OrderItem item)
        {
            OrdersItems.Remove(item);
        }

        public double Total()
        {
            double Total = 0;
            foreach(Aula132_OrderItem item in OrdersItems)
            {
                Total += item.SubTotal();
            }

            return Total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:MM:ss"));
            sb.AppendLine("Order status: " + Status.ToString());
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order Items:");
            foreach(Aula132_OrderItem item in OrdersItems)
            {
                sb.AppendLine(item.ToString());
            }
            sb.Append("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
