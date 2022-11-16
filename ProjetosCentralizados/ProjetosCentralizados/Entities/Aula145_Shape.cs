using ProjetosCentralizados.Entities.Enums;

namespace ProjetosCentralizados.Entities
{
    abstract internal class Aula145_Shape
    {
        Aula145_Color Color { get; set; }

        public Aula145_Shape(Aula145_Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
