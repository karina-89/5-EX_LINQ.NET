using System;
using System.Linq;

namespace Linq_Fase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            int maxNumero = numeros.Max();
            int minNumero = numeros.Min();
            double avgNumero = numeros.Average();

            Console.WriteLine($"El valor máximo es {maxNumero}.");
            Console.WriteLine($"El valor mínimo es {minNumero}.");
            Console.WriteLine($"El valor promedio es {avgNumero}.");
        }
    }
}
