using Microsoft.VisualBasic;
using System.Text;

namespace ProjetosCentralizados.Entities
{
    internal class Aula132_Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Aula132_Client (string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + "(" + BirthDate.ToString("dd/MM/yyyy") + ") - " + Email);
            return sb.ToString();
        }
    }
}
