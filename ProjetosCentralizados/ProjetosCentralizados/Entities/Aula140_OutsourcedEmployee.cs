using System.Globalization;
using System.Text;

namespace ProjetosCentralizados.Entities
{
    internal class Aula140_OutsourcedEmployee : Aula140_Employee
    {
        public double AdditionalCharge { get; set; }
        public double PercentageAdditionalCharge { get; set; } = 1.1;

        public Aula140_OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        sealed public override double Payment()
        {
            return (Hours * ValuePerHour) + (AdditionalCharge * PercentageAdditionalCharge);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name + " - $ " + Payment().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
