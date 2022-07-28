using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Principal
    {
        static int menu;
        public static void Main()
        {
            try
            {
                Console.WriteLine("Ejercicios Leandro Ramírez");
                Console.WriteLine("1.- Ejercicios Arreglos\n2.- Ejercicios Metodos");
                menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    Console.WriteLine("1.- Notas Alumnos\n2.- Ingresar Clientes\n3.- Sumar los precios de los productos");
                    menu = int.Parse(Console.ReadLine());
                    if (menu == 1)
                    {
                        Ejercicios.Notas();
                    }
                    else if (menu == 2)
                    {
                        Ejercicios.Clientes();
                    }
                    else if (menu == 3)
                    {
                        Ejercicios.Precios();
                    }
                    else
                    {
                        Console.WriteLine("Error de Digitación");
                    }
                }
                else if (menu == 2)
                {
                    Console.WriteLine("1.- Cambio de divisas\n2.- Area de un rectangulo\n3.- Identificar la edad de una persona\n4.- Tabla de multiplicar de un numero\n5.- Salir");
                    menu = int.Parse(Console.ReadLine());
                    if (menu == 1)
                    {
                        Ejercicios.Divisas();
                    }
                    else if (menu == 2)
                    {
                        Ejercicios.AreaRectangulo();
                    }
                    else if (menu == 3)
                    {
                        Ejercicios.Edad();
                    }
                    else if (menu == 4)
                    {
                        Ejercicios.Multiplicar();
                    }
                    else if (menu == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Salió del programa");
                    }
                    else
                    {
                        Console.WriteLine("Error de digitación");
                    }
                }

            }catch (Exception e)
            {
                Console.WriteLine("Error de digitación");
            }
        }
    }
}
