using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args) { 
            Humano Pessoa1;
            Humano Pessoa2;

            Pessoa1 = Pessoa2 = new Humano();
            Pessoa1.sexo = 'M';
            Pessoa1.altura = 1.5f;
            Pessoa2.sexo = 'F';
            Pessoa2.altura = 1.0f;

            Console.WriteLine(Pessoa1.sexo);

        }
    }

    class Humano
    {
        public float altura;
        public char sexo;
    }
}