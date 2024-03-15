using System;

namespace CalculoRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a altura do retangulo");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a largura do retangulo");
            double largura = double.Parse(Console.ReadLine());
            double area = altura * largura;
            Console.WriteLine($"Area do retângulo: {area.ToString("F2")}");
            double perimetro = 2 * (altura + largura);
            Console.WriteLine("O valor do perimetro é : " +  perimetro.ToString("F2"));
            double diagonal = Math.Sqrt((altura * altura) + (largura * largura));
            Console.WriteLine("O valor da diagonal é : " + diagonal.ToString("F2"));
        }
    }
}
