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
            string contrasenia = "", leerContrasenia = "";
            int intentos = 0;
            bool contraseniaCorrecta = false;

            Console.Write("Registre su contraseña: ");
            contrasenia = Console.ReadLine();

            while (!contraseniaCorrecta & intentos < 3)
            {
                switch (intentos)
                {
                    case 0:
                        Console.Write("Ingrese su contraseña: ");
                        leerContrasenia = Console.ReadLine();

                        if (contrasenia == leerContrasenia)
                            contraseniaCorrecta = true;
                        else
                            intentos++;
                        break;

                    case 1:
                        Console.Write("Contraseña incorrecta. Ingrese su contraseña: ");
                        leerContrasenia = Console.ReadLine();

                        if (contrasenia == leerContrasenia)
                            contraseniaCorrecta = true;
                        else
                            intentos++;
                        break;
                    case 2:
                        Console.Write("Contraseña incorrecta. Ingrese su contraseña: ");
                        leerContrasenia = Console.ReadLine();

                        if (contrasenia == leerContrasenia)
                            contraseniaCorrecta = true;
                        else
                            intentos++;

                        break;
                }
            }

            if (contraseniaCorrecta)
                Console.WriteLine("Bienvenido!!");
            else
                Console.WriteLine("Tres veces fallidas");

            Console.ReadKey();

        }
    }
}
