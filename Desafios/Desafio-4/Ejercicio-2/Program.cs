using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] facturacionMes = {10,20,30,10,30,50,10,40,70,10,50,90};
            int[] facturacionTrimestre = new int[4];

            int meses = 0;
            int sumaTrimestre = 0;
            int i = 0;
            do
            {
                sumaTrimestre = facturacionMes[meses] + facturacionMes[meses + 1] + facturacionMes[meses + 2];
                Console.WriteLine($"Trimestre {++i}\t {sumaTrimestre}");
                meses += 3;
            } while (meses < facturacionMes.Length);

            Console.WriteLine("\nPresione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
