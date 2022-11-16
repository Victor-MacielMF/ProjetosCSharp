//Aula 128

namespace ProjetosCentralizados.Entities
{
    internal class Aula128_Departament
    {
        public string Name { get; set; }

        public Aula128_Departament(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Departamento: " + Name;
        }
    }
}
