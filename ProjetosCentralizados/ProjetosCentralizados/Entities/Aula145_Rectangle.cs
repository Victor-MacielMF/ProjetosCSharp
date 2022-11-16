using ProjetosCentralizados.Entities.Enums;
using System.Globalization;
using System.Text;

namespace ProjetosCentralizados.Entities
{
    internal class Aula145_Rectangle : Aula145_Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Aula145_Rectangle(Aula145_Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public sealed override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Area().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
