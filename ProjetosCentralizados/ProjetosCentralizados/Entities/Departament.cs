//Aula 128

namespace ProjetosCentralizados.Entities
{
    internal class Departament
    {
        public string Name { get; set; }

        public Departament(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Departamento: " + Name;
        }
    }
}
