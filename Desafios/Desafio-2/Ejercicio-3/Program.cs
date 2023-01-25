using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la primer nota: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la segunda nota: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 >= 4 & n2 >= 4)
            {
                Console.WriteLine("Aprobado");
            } else if (n1 < 4 & n2 < 4)
            {
                Console.WriteLine("Desaprobado");
            } else if (n1 < 4)
            {
                Console.WriteLine("Recuperar primer parcial");
            } else
            {
                Console.WriteLine("Recuperar segundo parcial");
            }

            Console.WriteLine("\nIngrese una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
