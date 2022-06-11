using System;

namespace CG_Biblioteca
{
    /// <summary>
    /// Classe com funções matemáticas.
    /// </summary>
    public abstract class Matematica
    {
        /// <summary>
        /// Função para calcular um ponto sobre o perímetro de um círculo informando um ângulo e raio.
        /// </summary>
        /// <param name="angulo"></param>
        /// <param name="raio"></param>
        /// <returns></returns>
        public static Ponto4D GerarPtosCirculo(double angulo, double raio)
        {
            Ponto4D pto = new Ponto4D();
            pto.X = (raio * Math.Cos(Math.PI * angulo / 180.0));
            pto.Y = (raio * Math.Sin(Math.PI * angulo / 180.0));
            pto.Z = 0;
            return (pto);
        }

        public static double GerarPtosCirculoSimétrico(double raio)
        {
            return (raio * Math.Cos(Math.PI * 45 / 180.0));
        }

        public static double DistaciaEntrePontos(double x1, double y1, double x2, double y2){
            return Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
        }

    }
}