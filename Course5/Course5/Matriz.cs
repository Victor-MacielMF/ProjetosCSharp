using System;


namespace Course5
{
    internal class Matriz
    {
        public int[,] MatrizVariavel { get; private set; }

        public Matriz(int x, int y)
        {
            MatrizVariavel = new int[x, y];
        }

        public void PopularMatriz()
        {
            for (int i = 0; i < MatrizVariavel.GetLength(0); i++)
            {
                string[] ValoresTexto = Console.ReadLine().Split(' ');
                for (int j = 0; j < ValoresTexto.Length; j++)
                {
                    MatrizVariavel[i, j] = int.Parse(ValoresTexto[j]);
                }
            }
        }

        public string Diagonal()
        {
            int NumerosAdicionados = 0;
            string Texto = "";
            for (int i = 0; i < MatrizVariavel.GetLength(0); i++)
            {
                Texto += MatrizVariavel[i, NumerosAdicionados] + " ";
                NumerosAdicionados++;
            }
            return Texto;
        }

        public int QuantidadeNumerosNegativos()
        {
            int QuantidadeNegativos = 0;
            for (int i = 0; i < MatrizVariavel.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizVariavel.GetLength(1); j++)
                {
                    if (MatrizVariavel[i, j] < 0)
                    {
                        QuantidadeNegativos++;
                    }
                }
            }
            return QuantidadeNegativos;
        }

        public string VizinhosDoIndex()
        {
            Console.WriteLine("Digite os valorex X e Y: ");
            string[] Coordenada = Console.ReadLine().Split(' ');
            int x = int.Parse(Coordenada[0]);
            int y = int.Parse(Coordenada[1]);

            string Texto = "Vizinhos do index: " + x + ", " + y + "\n";

            if (x > 0)
            {
                Texto += "Topo: " + MatrizVariavel[x - 1, y] + "\n";
            }
            if (y + 1 < MatrizVariavel.GetLength(1))
            {
                Texto += "Direita: " + MatrizVariavel[x, y + 1] + "\n";
            }
            if (x + 1 < MatrizVariavel.GetLength(0))
            {
                Texto += "Baixo: " + MatrizVariavel[x + 1, y] + "\n";
            }
            if (y > 0)
            {
                Texto += "Esquerda: " + MatrizVariavel[x, y - 1] + "\n";
            }

            return Texto;
        }

        public string VizinhosDoNumero()
        {
            Console.WriteLine("Digite o número: ");
            int Numero = int.Parse(Console.ReadLine());

            string Texto = "";
            int QuantidadeNumerosEncontrados = 0;

            for (int i = 0; i < MatrizVariavel.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizVariavel.GetLength(1); j++)
                {
                    if (MatrizVariavel[i, j] == Numero)
                    {
                        if (QuantidadeNumerosEncontrados > 0)
                        {
                            Texto += "\n";
                        }

                        Texto += "Posição " + i + "," + j + "\n";

                        if (j > 0)
                        {
                            Texto += "Esquerda: " + MatrizVariavel[i, j - 1] + "\n";
                        }
                        if (j + 1 < MatrizVariavel.GetLength(1))
                        {
                            Texto += "Direita: " + MatrizVariavel[i, j + 1] + "\n";
                        }
                        if (i > 0)
                        {
                            Texto += "Topo: " + MatrizVariavel[i - 1, j] + "\n";
                        }
                        if (i + 1 < MatrizVariavel.GetLength(0))
                        {
                            Texto += "Baixo: " + MatrizVariavel[i + 1, j] + "\n";
                        }

                        QuantidadeNumerosEncontrados++;
                    }
                }
            }

            return Texto;
        }

        public override string ToString()
        {
            string Texto = "";
            for (int i = 0; i < MatrizVariavel.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizVariavel.GetLength(1); j++)
                {
                    Texto += MatrizVariavel[i, j] + " ";
                    if (j + 1 == MatrizVariavel.GetLength(1))
                    {
                        Texto += "\n";
                    }
                }
            }
            return Texto;
        }

    }
}
