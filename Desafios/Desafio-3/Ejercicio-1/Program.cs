using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mes = 1;
            double dinero = 1000;

            do
            {
                Console.WriteLine(dinero);
                dinero *= 1.02;
                mes++;
            } while (mes <= 12);

            Console.WriteLine($"Dinero: {dinero}");

            Console.WriteLine("Ingrese cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
