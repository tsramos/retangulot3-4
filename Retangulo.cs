using System;

namespace CalculoRetangulo
{
    public class Retangulo
    {
        public double Altura;
        public double Largura;
        public string Cor;

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double CalculaArea()
        {
            return Altura * Largura;
        }

        public void ExibePerimetro()
        {
            double perimetro = 2 * (Altura + Largura);
            Console.WriteLine("O valor do perimetro � : " + perimetro.ToString("F2"));
        }

        public void ExibeDiagonal()
        {
            double diagonal = Math.Sqrt((Altura * Altura) + (Largura * Largura));
            Console.WriteLine("O valor da diagonal � : " + diagonal.ToString("F2"));
        }
    }
}