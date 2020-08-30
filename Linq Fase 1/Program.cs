using System;
using System.Linq;

namespace Linq_Fase_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            int[] numpares = numeros.Where(n => n % 2 == 0).ToArray();

            Console.WriteLine(string.Join(",", numpares));
        }
    }
}
