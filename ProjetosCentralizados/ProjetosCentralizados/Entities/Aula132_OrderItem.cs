using System.Globalization;
using System.Text;

namespace ProjetosCentralizados.Entities
{
    internal class Aula132_OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Aula132_Product Produto { get; set; }


        public Aula132_OrderItem(int quantity, Aula132_Product produto)
        {
            Quantity = quantity;
            Price = produto.Price;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Produto.Name + ", $" + Produto.Price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantity: "+ Quantity + ", Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
