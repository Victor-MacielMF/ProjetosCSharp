using System.Globalization;
using System.Text;

namespace ProjetosCentralizados.Entities
{
    internal class Aula142_Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Aula142_Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
