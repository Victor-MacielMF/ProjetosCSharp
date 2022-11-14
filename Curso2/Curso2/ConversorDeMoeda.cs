namespace Curso
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 6.00;

        public static double RealParaDolar(double cotacao, double qtd)
        {
            return cotacao * qtd * (1 + IOF / 100);
        }
    }
}
