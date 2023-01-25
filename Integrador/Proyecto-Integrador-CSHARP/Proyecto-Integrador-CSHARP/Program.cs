using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador_CSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaración de variables
            string nombre, apellido, correo, carrera = " ";
            int edad, opcionCurso;
           

            List<string> listaNet = new List<string> { "HTML5: Fundamentos Web","C# .NET para no programadores",
            "Introducción A Base De Datos SQL", "Javascript desde cero", "Introducción al paradigma de objetos"};
            List<string> listaJava = new List<string> { "Java para no programadores","Introducción al paradigma de objetos",
            "Java standard 11 Web Programming","Java Web API", "Java Spring"};
            List<string> listaPhp = new List<string> { "Programación Web en PHP y MySQL", "PHP - Programación Orientada a Objetos", "PHP Arquitectura Avanzada", "PHP MVC Laravel" };
            List<List<string>> listaDeListas = new List<List<string>> { listaNet, listaJava, listaPhp };
            List<string> cursosAlumno = new List<string>();


            //pedido y captura de datos
            Console.WriteLine("Ingresá tu nombre");
             nombre = Console.ReadLine();
             Console.WriteLine("Ingresá tu apellido");
             apellido = Console.ReadLine();
             Console.WriteLine("Ingresá tu correo electrónico");
             correo = Console.ReadLine();
             Console.WriteLine("Ingresá tu edad");
             edad = Convert.ToInt32(Console.ReadLine());

             //Muestro datos
             Console.WriteLine("*** Datos del alumno ***");
             Console.WriteLine($"Nombre: {nombre}");
             Console.WriteLine($"Apellido: {apellido}");
             Console.WriteLine($"Correo Electrónico: {correo}");
             Console.WriteLine($"Edad: {edad}");

             //Confirmación de datos
             Console.WriteLine("Los datos son correctos?. Presione S para Si N para no");
             char opcion = Convert.ToChar(Console.ReadLine());

            if (opcion == 's' || opcion == 'S')
            {
                Console.WriteLine("Seleccione código de carrera");
                Console.WriteLine("1- Programación .NET");
                Console.WriteLine("2- Programación JAVA");
                Console.WriteLine("3- Programación PHP");
                int opcionCarrera = Convert.ToInt32(Console.ReadLine());

                switch (opcionCarrera)
                {
                    case 1:
                        carrera = "Programacion .NET";
                        break;
                    case 2:
                        carrera = "Programación JAVA";
                        break;
                    case 3:
                        carrera = "Programación PHP";
                        break;
                    default:
                        Console.WriteLine("Carrera inexistente. Ejecute la aplicación nuevamente");
                        break;

                }
                Console.Clear();

                for (int i = 0; i < listaDeListas[opcionCarrera-1].Count; i++) {
                    Console.WriteLine(i+1+". " + listaDeListas[opcionCarrera-1][i]);
                }

                char proseguir;
               
                do {
                    proseguir = ' ';
                    Console.WriteLine("Seleccione el curso al que desea inscribirse:");
                    opcionCurso = Convert.ToInt32(Console.ReadLine());
                    if (opcionCurso > 0 && opcionCurso <= listaDeListas[opcionCarrera - 1].Count)
                        cursosAlumno.Add(listaDeListas[opcionCarrera - 1][opcionCurso - 1]);
                    else
                        Console.WriteLine("Curso inexistente.");
                    
                    Console.WriteLine("Desea seguir inscribiendose a cursos?: S para si, N para no");

                    proseguir = Convert.ToChar(Console.ReadLine());

                } while (proseguir == 's' || proseguir == 'S');

                
                Console.WriteLine("\n***Constancia de Inscripción***");
                Console.WriteLine($"Alumno: {nombre} {apellido}");
                Console.WriteLine($"Correo electrónico: {correo}");
                Console.WriteLine($"Carrera: {carrera}");
                Console.WriteLine("Cursos en los que está inscripto:");

                int contador = 0;
                foreach (var i in cursosAlumno)
                {
                    contador++;
                    Console.WriteLine($"\t{contador}. "+i);
                }

            }
            else if (opcion == 'n' || opcion == 'N')
            {
                Console.WriteLine("Ejecute nuevamente la aplicación e ingrese los datos correctos");
            }

            else {
                Console.WriteLine("Opción incorrecta");
            }

            Console.WriteLine("\nPresione una tecla para finalizar...");
            Console.ReadKey();
        }
    }

}
    

