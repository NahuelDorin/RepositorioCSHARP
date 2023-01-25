using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;

            Console.Write("Ingrese el primer numero: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine($"\nSuma: {n1 + n2}");
                Console.WriteLine($"Diferencia: {n1 - n2}");
            }
            else
            {
                Console.WriteLine($"\nProducto: {n1 * n2}");
                Console.WriteLine($"Division: {n1 / n2}");
            }

            Console.WriteLine("\nIngrese una tecla para finalizar...");
            Console.ReadKey();

        }
    }
}
