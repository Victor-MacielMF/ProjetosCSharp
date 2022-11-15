using System.Drawing;

namespace Somatório_de_Horas
{
    internal class Horas
    {
        public double MinutosTotais { get; set; }

        public  void SomarHoras(string horas)
        {

            if (int.TryParse(horas, out int horasConvertidaInt))
            {
                MinutosTotais += (horasConvertidaInt * 60);
            }
            else
            {
                string[] valores = horas.Split(".");
                MinutosTotais += (int.Parse(valores[0]) * 60 + int.Parse(valores[1]));
            }
        }

        public override string ToString()
        {
            return MinutosTotais.ToString();
        }
    }
}
}
