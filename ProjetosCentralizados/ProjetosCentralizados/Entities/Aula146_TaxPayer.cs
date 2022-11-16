namespace ProjetosCentralizados.Entities
{
    abstract internal class Aula146_TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Aula146_TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
