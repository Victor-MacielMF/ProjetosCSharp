using System.Globalization;
using System.Text;

namespace ProjetosCentralizados.Entities
{
    internal class Aula146_Company : Aula146_TaxPayer
    {
        public int NumberOfEmployees { get; set; }
        public double HighlyImpost { get; private set; } = 0.16;
        public double MediumImpost { get; private set; } = 0.14;

        public Aula146_Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public sealed override double Tax()
        {
            return NumberOfEmployees > 10 ? MediumImpost * AnualIncome : HighlyImpost * AnualIncome;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
