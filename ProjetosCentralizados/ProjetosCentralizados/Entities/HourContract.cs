//Aula 128

namespace ProjetosCentralizados.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public Double TotalValue()
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            return "Data: " + Date + "\n" +
                "Valor por hora: " + ValuePerHour + "\n" +
                "Horas contratadas: " + Hours;
        }
    }
}
