using System.Globalization;
using System.Text;

namespace ProjetosCentralizados.Entities
{
    internal class Aula146_Individual : Aula146_TaxPayer
    {
        public double HealthExpenditures { get; set; }
        public double TaxHealth { get; private set; } = 0.5;
        public double ValueIncomeLow { get; private set; } = 20000.00;
        public double TaxValueLow { get; private set; } = 0.15;
        public double TaxValueHigh { get; private set; } = 0.25;

        public Aula146_Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public sealed override double Tax()
        {
            return AnualIncome < ValueIncomeLow ? (AnualIncome * TaxValueLow) - (HealthExpenditures * TaxHealth) : (AnualIncome * TaxValueHigh) - (HealthExpenditures * TaxHealth);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
