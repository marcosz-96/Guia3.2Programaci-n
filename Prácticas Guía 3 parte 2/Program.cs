using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prácticas_Guía_3_parte_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ejercicio 1 de la Guía 3.2: Hacer una calculadora básica

            /*Console.WriteLine("Ingrese el Primer Número");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el Segundo Número");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la Operación que desa realizar (+,-,*,/)");

            char tecla = Convert.ToChar(Console.ReadLine());

            double resultado = 0;

            switch (tecla)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por CERO");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("La Operación es inválida");
                    }
                    break;
            } 
            Console.WriteLine($"El resultado es: {resultado}");*/


            //Ejercicio 2 de la Guía 3.2: Días de la semana

            /*Console.WriteLine("Elige un número del 1 al 7 para seleccionar un día de la semana");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Opción Inválida");
                    break;
            }*/
            

            //Ejercicio 3 de la Guía 3.2: Conversiones de calificaciones a letras

            /*Console.WriteLine("Escriba su calificación");

            int calificacion = int.Parse(Console.ReadLine());

            if (calificacion == 10)
            {
                Console.WriteLine("E"); //Excelente
                return;
            }
            if (calificacion >= 8)
            {
                Console.WriteLine("S"); //Satisfactorio
                return;
            }
            if (calificacion >= 4)
            {
                Console.WriteLine("B"); //Bien
            }
            if (calificacion <= 3)
            {
                Console.WriteLine("M"); //Mal
            }*/


            //Ejercicio 4 de la Guía 3.2: Clasificación de Triángulos

            /*Console.WriteLine("Para clasificar el tipo de triángulo");
            Console.WriteLine();
            Console.WriteLine("Ingrese el valor del Primer Lado");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del Segundo Lado");
            double valor2 = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("Ingrese el valor del Tercer Lado");
            double valor3 = Convert.ToDouble(Console.ReadLine());

            if (valor1 == valor2 && valor2 == valor3)
            {
                Console.WriteLine("El Triángulo es Equilátero");
                return;
            }
            if (valor1 == valor2 && valor2 != valor3)
            {
                Console.WriteLine("El Triángulo es Isósceles");
                return;
            }
            if (valor1 != valor2 && valor2 != valor3)
            {
                Console.WriteLine("El Triángulo es Escaleno");
                return;
            }*/


            //Ejercicio 5 de la Guía 3.2: Estaciones del Año


        }
    }
}
