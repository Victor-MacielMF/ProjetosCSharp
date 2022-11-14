using System.Globalization;

namespace Course4
{
    class Funcionario
    {
        public int Id { get; private set; }
        public string Nome {get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalarial(double porcentagem)
        {
            if(porcentagem > 0)
            {
                Salario *= (1+porcentagem/100.00);
            }
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture) ;
        }
    }
}
