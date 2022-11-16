//Aula 128
using ProjetosCentralizados.Entities.Enums;

namespace ProjetosCentralizados.Entities
{
    internal class Aula128_Worker
    {
        public string Name { get; set; }
        public Aula128_WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Aula128_Departament Departament { get; set; }
        public List<Aula128_HourContract> Contracts { get; set; } = new List<Aula128_HourContract>();

        public Aula128_Worker(string name, Aula128_WorkerLevel level, double baseSalary, Aula128_Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(Aula128_HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(Aula128_HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double TotalSalary = BaseSalary;

            foreach (Aula128_HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    TotalSalary += contract.TotalValue();
                }
            }

            return TotalSalary;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\n" +
                "Departament: " + Departament.Name;
        }
    }
}
