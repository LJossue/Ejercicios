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

        /// ARREGLOS
        public static void Notas()
        {
            string[] alumno = new string[5];
            int[] parcial = new int[5];
            int[] oral = new int[5];
            int[] final = new int[5];
            for (int a = 1; a < alumno.Length; a++)
            {
                Console.WriteLine("Ingrese el nombre del {0} alumno", a);
                alumno[a] = Console.ReadLine();
                Console.WriteLine("Ingrese su nota del parcial");
                parcial[a] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su nota del examen oral");
                oral[a] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su nota del examen final");
                final[a] = int.Parse(Console.ReadLine());
                int sumaresultado = parcial[a] + oral[a] + final[a];
                int promedio = sumaresultado / 3;
                if (promedio >= 7)
                {
                    Console.WriteLine($"El alumno {alumno[a]} APROBO, su promedio fue {promedio}");
                }
                else if (promedio < 7)
                {
                    Console.WriteLine($"El alumno {alumno[a]} REPROBO, su promedio fue {promedio}");
                }

                else if (promedio <= 0 || promedio > 10)
                {
                    Console.WriteLine("Error en el calculo");
                }

            }
        }

        public static void Clientes()
        {
            string[] nombre = new string[5];
            string[] apellido = new string[5];
            int[] edad = new int[5];
            string[] sexo = new string[5];
            int i;
            for (i = 1; i < 6; i++)
            {
                Console.WriteLine("Ingrese los datos del {0} cliente \n", i);
                Console.Write("Nombre : ");
                nombre[i] = Console.ReadLine();
                Console.Write("Apellido : ");
                apellido[i] = Console.ReadLine();
                Console.Write("Edad : ");
                edad[i] = int.Parse(Console.ReadLine());
                Console.Write("Sexo : ");
                sexo[i] = Console.ReadLine();
                Console.WriteLine("\nEl cliente {0} se registro con los siguientes datos:\n ", i);
                Console.WriteLine($"Nombre: {nombre[i]}, Apellido: {apellido[i]}, Edad: {edad[i]}, Sexo: {sexo[i]}\n");
            }
        }

        public static void Precios()
        {
            int cantidad;
            double contador = 0;
            Console.WriteLine("Ingrese la cantidad de productos");
            cantidad = int.Parse(Console.ReadLine());
            string[] producto = new string[cantidad];
            double[] precio = new double[cantidad];
            for (int a = 0; a < precio.Length; a++)
            {
                Console.WriteLine("Ingrese el nombre del {0} producto", a + 1);
                producto[a] = Console.ReadLine();
                Console.WriteLine("Ingrese el precio del {0} producto", a + 1);
                precio[a] = double.Parse(Console.ReadLine());
                contador = contador + precio[a];
            }
            Console.WriteLine("El total es " + contador);
        }


        /// METODOS
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
