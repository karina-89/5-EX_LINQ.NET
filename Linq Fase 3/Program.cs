using System;
using System.Linq;

namespace Linq_Fase_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            int[] mayor5 = numeros.Where(n => n > 5).ToArray();
            int[] menor5 = numeros.Where(n => n < 5).ToArray();

            Console.WriteLine($"Los numeros mayores que 5 son: {string.Join(",", mayor5)}");
            Console.WriteLine($"Los numeros menores que 5 son: {string.Join(",", menor5)}");
        }
    }
}
