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
            int mes = 1;
            double dinero = 1000;

            do
            {
                dinero *= 1.03;
                mes++;
            } while (dinero<=1200);

            Console.WriteLine($"Dinero: {dinero} \tMes: {mes}");


            Console.WriteLine("\nIngrese una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
