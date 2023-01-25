using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int IVA = 21;

            double Remera = 59.90, Pantalon = 99.90, Campera = 149.90;

            Console.WriteLine($"Remera: {Remera} \tCon IVA: {Remera += Remera * IVA / 100}");
            Console.WriteLine($"Pantalón: {Pantalon} \tCon IVA: {Pantalon += Pantalon * IVA / 100}");
            Console.WriteLine($"Campera: {Campera} \tCon IVA: {Campera += Campera * IVA / 100}");

            Console.WriteLine("\nIngrese una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
