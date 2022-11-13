using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3ACT2_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreUsuario, contraseñaUsuario;
            string confirmarUsuario, confirmarContraseña;
            int num1, num2, num3;
            Console.WriteLine("Ingresa los datos para administrar tu perfil");
            Console.WriteLine("Ingresa tu nombre de usuario:");
            nombreUsuario = Console.ReadLine();
            Console.WriteLine("Vuelve a ingresar tu nombre de usuario:");
            confirmarUsuario = Console.ReadLine();
            Console.WriteLine("Ingresa tu contraseña:");
            contraseñaUsuario = Console.ReadLine();
            Console.WriteLine("Vuelve a ingresar tu contraseña:");
            confirmarContraseña = Console.ReadLine();

            if (nombreUsuario==confirmarUsuario)
            {
                if (contraseñaUsuario == confirmarContraseña)
                {
                    Console.WriteLine("Elije el tamaño de la ventana");
                    Console.WriteLine("Ingresa 1 para tamaño chico, 2 para mediano y 3 para grande:");
                    num3 = Convert.ToInt16(Console.ReadLine());

                    switch (num3)
                    {
                        case 1:
                            Console.WindowHeight = 20;
                            Console.WindowWidth = 20;
                            break;
                        case 2:
                            Console.WindowHeight = 30;
                            Console.WindowWidth = 30;
                            break;
                        case 3:
                            Console.WindowHeight = 40;
                            Console.WindowWidth = 40;
                            break;

                    }
                    Console.WriteLine("Elije un color para la consola");
                    Console.WriteLine("Ingresa 1 para color amarillo, 2 para color azul y 3 para color rojo");
                    num1 = Convert.ToInt16(Console.ReadLine());
                    switch (num1)
                    {
                        case 1:
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            break;
                        case 2:
                            Console.BackgroundColor = ConsoleColor.Blue;
                            break;
                        case 3:
                            Console.BackgroundColor = ConsoleColor.Red;
                            break;
                    }

                    Console.WriteLine("Elije un color para el color de la letra");
                    Console.WriteLine("Ingresa 1 para color negro, 2 para rojo y 3 para azul");
                    num2 = Convert.ToInt16(Console.ReadLine());

                    switch (num2)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Black;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                    }
                    Console.WriteLine("Haz ingresado a tu perfil");
                    Console.WriteLine("Nombre: Marco Manuel Jimenez Mendez");
                    Console.WriteLine("Matricula: 221000106");
                    Console.WriteLine("Grupo: 1C");
                    Console.WriteLine("Carrera: Ingenieria en sistemas computacionales");
                    Console.WriteLine("Correo electronico: marco.jimenez68888@gmail.com");
                    Console.WriteLine("Numero telefonico: 8721569470");
                }
                else
                {
                    Console.WriteLine("Nombre de usuario incorrecto");
                    Console.WriteLine("Contraseña incorrecta");
                }
                Console.ReadKey();

            }

        }
    }
}
