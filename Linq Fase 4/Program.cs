using System;
using System.Linq;

namespace Linq_Fase_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = { "David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol" };

            string[] nombresO = nombre.Where(n => n[0] == 'O').ToArray();
            string[] nombresLargos = nombre.Where(n => n.Length > 6).ToArray();
            string[] nombresDesc = nombre.OrderByDescending(n => n).ToArray();

            Console.WriteLine($"Los nombres que empiezan por O son: {string.Join(",", nombresO)}");
            Console.WriteLine($"Los nombres que contienen más de 6 letras son: {string.Join(",", nombresLargos)}");
            Console.WriteLine($"Los nombres ordenados descendientemente son: {string.Join(",", nombresDesc)}");
        }
    }
}
