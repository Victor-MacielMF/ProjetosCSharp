using System.Globalization;
using System.Text;

namespace ProjetosCentralizados.Entities
{
    internal class Aula142_ImportedProduct : Aula142_Product
    {
        public double CustomsFee { get; set; }

        public Aula142_ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        sealed public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")");

            return sb.ToString();
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
