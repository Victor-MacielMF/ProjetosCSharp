using System.Text;
using System.Globalization;

namespace ProjetosCentralizados.Entities
{
    internal class Aula140_Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Aula140_Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name + " - $ " + Payment().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
