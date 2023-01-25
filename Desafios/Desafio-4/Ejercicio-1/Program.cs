using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vectorOrigen = { 1002, 104, 309, 500 };
            int[] vectorDestino = new int[4];

            for (int i = 0; i<vectorOrigen.Length; i++)
            {
                vectorDestino[vectorDestino.Length - i - 1] = vectorOrigen[i];
            }

            Console.WriteLine("Posicion\t Origen\t\tDestino");
            for (int i = 0; i<vectorDestino.Length; i++)
            {
                Console.Write(i);
                Console.Write($"\t\t {vectorOrigen[i]}");
                Console.WriteLine($"\t\t{vectorDestino[i]}");
            }

            Console.WriteLine("\nPresione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
