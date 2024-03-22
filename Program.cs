

using System;
using CalculoRetangulo.Entidades;

namespace CalculoRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {            
            Casa c1 = new Casa(2,1,1,2);

            Console.WriteLine(c1.ToString());
            Console.WriteLine(c1);
        }
    }
}
