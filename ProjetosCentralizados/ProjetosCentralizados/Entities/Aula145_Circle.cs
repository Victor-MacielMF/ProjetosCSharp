using System.Globalization;
using System.Text;
using ProjetosCentralizados.Entities.Enums;

namespace ProjetosCentralizados.Entities
{
    internal class Aula145_Circle : Aula145_Shape
    {
        public double Radius { get; set; }

        public Aula145_Circle(Aula145_Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public sealed override double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Area().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
