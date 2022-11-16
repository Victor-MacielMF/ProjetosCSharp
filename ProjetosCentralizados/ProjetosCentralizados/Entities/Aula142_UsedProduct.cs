using System.Globalization;
using System.Text;

namespace ProjetosCentralizados.Entities
{
    internal class Aula142_UsedProduct : Aula142_Product
    {
        private DateTime ManufactureDate { get; set; }

        public Aula142_UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        sealed public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + "(Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")");

            return sb.ToString();
        }
    }
}
