//Aula 128
using ProjetosCentralizados.Entities.Enums;

namespace ProjetosCentralizados.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double TotalSalary = BaseSalary;

            foreach (HourContract contract in Contracts)
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
