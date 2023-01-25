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
            int nota=-1;

            Console.WriteLine("Ingrese una nota entre 1 a 10, para finalizar ingrese 0");
            nota = Convert.ToInt32(Console.ReadLine());
            while (nota != 0)
            {
                if (nota >= 10 | nota < 0)
                {
                    Console.Write("ERROR. ");
                }
                else if (nota >= 7)
                    Console.WriteLine("Condicion: PROMOCIONADO");
                else if (nota >= 4)
                    Console.WriteLine("Condicion: APROBADO");
                else
                    Console.WriteLine("Condicion: DESAPROBADO");


                Console.WriteLine("Ingrese una nota entre 1 a 10, para finalizar ingrese 0");
                nota = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
