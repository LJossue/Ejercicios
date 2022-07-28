using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicios
    {
        static double x, y;
        static int menu;
        public static void Divisas()
        {
            Console.WriteLine("1.- Cambio Pesos a Dolar");
            Console.WriteLine("2.- Cambio Pesos a Euro");
            Console.WriteLine("2.- Cambio Pesos a Yuanes");
            menu = int.Parse(Console.ReadLine());
            if (menu == 1)
            {
                Console.WriteLine("Ingrese la cantidad de Pesos");
                x = double.Parse(Console.ReadLine());

                Console.WriteLine($"El cambio en dolares es {x * 4469}");
            }
            else if (menu == 2) {
                Console.WriteLine("Ingrese la cantidad de Pesos");
                x = double.Parse(Console.ReadLine());

                Console.WriteLine($"El cambio en Euros es {x * 4512}");
            }
            else if (menu == 3)
            {
                Console.WriteLine("Ingrese la cantidad de Pesos");
                x = double.Parse(Console.ReadLine());

                Console.WriteLine($"El cambio en Yuanes es {x * 655}");
            }
            else
            {
                Console.WriteLine("Error de digitación");
            }
        }

        public static void AreaRectangulo()
        {
            Console.WriteLine("Area de un rectangulo");
            Console.WriteLine("Ingrese el largo del rectangulo");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el ancho del rectangulo");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine($"El area del rectangulo es: {x * y}");
        }
    
        public static void Edad()
        {
            Console.WriteLine("Identificar la edad de una persona");
            Console.WriteLine("Ingrese la edad de la persona");
            x = double.Parse(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("Error en la edad ingresada");
            }
            else if (x < 18)
            {
                Console.WriteLine("La persona es menor de edad");
            }
            else if (x >= 18 && x < 60)
            {
                Console.WriteLine("La persona es mayor de edad");
            }
            else if (x >=60)
            {
                Console.WriteLine("La persona es un adulto mayor");
            }

            
        }
        public static void Multiplicar()
        {
            Console.WriteLine("Tablas de multiplicar de un numero ingresado");
            Console.WriteLine("Ingrese el numero a multiplicar");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine($"La tabla de multiplicar del numero {x} es: ");
            Console.WriteLine($"{x} x 1 = {x * 1}");
            Console.WriteLine($"{x} x 2 = {x * 2}");
            Console.WriteLine($"{x} x 3 = {x * 3}");
            Console.WriteLine($"{x} x 4 = {x * 4}");
            Console.WriteLine($"{x} x 5 = {x * 5}");
            Console.WriteLine($"{x} x 6 = {x * 6}");
            Console.WriteLine($"{x} x 7 = {x * 7}");
            Console.WriteLine($"{x} x 8 = {x * 8}");
            Console.WriteLine($"{x} x 9 = {x * 9}");
            Console.WriteLine($"{x} x 10 = {x * 10}");
            Console.WriteLine($"{x} x 11 = {x * 11}");
            Console.WriteLine($"{x} x 12 = {x * 12}");
        }
    }
}
