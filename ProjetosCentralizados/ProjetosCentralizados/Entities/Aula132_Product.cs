
using System.Globalization;
using System.Text;

namespace ProjetosCentralizados.Entities
{
    internal class Aula132_Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Aula132_Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Produto: ");
            sb.AppendLine(Name);
            sb.Append("Preço: R$ ");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
