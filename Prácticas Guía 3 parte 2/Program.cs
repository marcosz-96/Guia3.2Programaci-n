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

            Console.WriteLine("Ingrese el Primer Número");
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
            Console.WriteLine($"El resultado es: {resultado}");


            //Ejercicio 2 de la Guía 3.2: Días de la semana

            Console.WriteLine("Elige un número del 1 al 7 para seleccionar un día de la semana");

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
            }


            //Ejercicio 3 de la Guía 3.2: Conversiones de calificaciones a letras

            Console.WriteLine("Escriba su calificación del 1 al 10");

            int calificacion = int.Parse(Console.ReadLine());

            if (calificacion == 10)
            {
                Console.WriteLine("E"); //Excelente
            }
            else if (calificacion >= 8 && calificacion < 10)
            {
                Console.WriteLine("S"); //Satisfactorio
            }
            else if (calificacion >= 4 && calificacion <= 7)
            {
                Console.WriteLine("B"); //Bien
            }
            else if (calificacion <= 3 && calificacion > 0)
            {
                Console.WriteLine("M"); //Mal
            }
            else if (calificacion > 10 || calificacion <= 0)
            {
                Console.WriteLine("Opción inválida. Ingrese del 1 al 10");
            }
            else
            {
                Console.WriteLine("Opción inválida. Ingrese nota numérica");
            }



            //Ejercicio 4 de la Guía 3.2: Clasificación de Triángulos

            Console.WriteLine("Para clasificar el tipo de triángulo");
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
            }


            //Ejercicio 5 de la Guía 3.2: Estaciones del Año

            Console.WriteLine("Escriba el número del mes del cual desea saber a estación del año pertenece");

            int numMes = int.Parse(Console.ReadLine());

            switch (numMes)
            {
                case 1:
                    Console.WriteLine("Estación de Verano");
                    break;
                case 2:
                    Console.WriteLine("Estación de Verano");
                    break;
                case 3:
                    Console.WriteLine("Termina el Verano y empieza el Otoño");
                    break;
                case 4:
                    Console.WriteLine("Estación de Otoño");
                    break;
                case 5:
                    Console.WriteLine("Estación de Otoño");
                    break;
                case 6:
                    Console.WriteLine("Termina el Otoño y empieza el Invierno");
                    break;
                case 7:
                    Console.WriteLine("Estación de Invierno");
                    break;
                case 8:
                    Console.WriteLine("Estación de Invierno");
                    break;
                case 9:
                    Console.WriteLine("Termina el Invierno y empieza la Primavera");
                    break;
                case 10:
                    Console.WriteLine("Estación de Primavera");
                    break;
                case 11:
                    Console.WriteLine("Estación de Primavera");
                    break;
                case 12:
                    Console.WriteLine("Termina la Primavera y empieza el Verano");
                    break;
                default:
                    Console.WriteLine("Opción Inválida");
                    break;
            }


            //Ejercicio 6 de la Guía 3.2: Días es un mes

            Console.Write("Escriba el número del mes del cual desea saber cuantos días tiene: ");
    
            int mes = int.Parse(Console.ReadLine());
            
            switch (mes)
            {
                case 1:
                    Console.WriteLine("Mes de enero, tiene 31 días");
                    break;
                case 2:
                    Console.WriteLine("Mes de febrero, tiene 29 días");
                    break;
                case 3:
                    Console.WriteLine("Mes de marzo, tiene 31 días");
                    break;
                case 4:
                    Console.WriteLine("Mes de abril, tiene 30 días");
                    break;
                case 5:
                    Console.WriteLine("Mes de mayo, tiene 31 días");
                    break;
                case 6:
                    Console.WriteLine("Mes de junio, tiene 30 días");
                    break;
                case 7:
                    Console.WriteLine("Mes de julio, tiene 31 días");
                    break;
                case 8:
                    Console.WriteLine("Mes de agosto, tiene 31 días");
                    break;
                case 9:
                    Console.WriteLine("Mes de septiembre, tiene 30 días");
                    break;
                case 10:
                    Console.WriteLine("Mes de octubre, tiene 31 días");
                    break;
                case 11:
                    Console.WriteLine("Mes de noviembre, tiene 30 días");
                    break;
                case 12:
                    Console.WriteLine("Mes de diciembre, tiene 31 días");
                    break;
                default:
                    Console.WriteLine("Opción Inválida, número de mes no encontrado");
                    break;
            }


            //Ejercicio 7 de la Guía 3.2: Conversiones de unidades de medida

            Console.Write("Escriba el número en centímetros que desea convertir: ");
            string input = Console.ReadLine();
            double centimetros = Convert.ToDouble(input);

            Console.WriteLine("Ingrese la medida a la cual desea convertir (m para metros o km para kilómetros):");
            string unit = Console.ReadLine().ToLower();

            switch (unit)
            {
                case "m":
                    double meters = centimetros / 100.0;
                    Console.WriteLine($"{centimetros} la cantidad de centímetros es igual a {meters} metros.");
                    break;
                case "km":
                    double kilometers = centimetros / 100000.0;
                    Console.WriteLine($"{centimetros} la cantidad de centímetros es igual a {kilometers} kilómetros.");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Solo puede escribir 'm' para metros o 'km' para kilómetros.");
                    break;
            }


            //Ejercicio 8 de la Guía 3.2: Descuento según la cantidad de artículos comprados
            //En el ejemplo se entiende que el precio base es de 1000.0$

            Console.Write("Escribe la cantidad de artículos que a comprado: "); 

            int cantidad = Convert.ToInt32(Console.ReadLine());

            double descuento = 0.0;

            if (cantidad < 10)
            {
                descuento = 0.0;
            }
            else if (cantidad >= 10 && cantidad  < 20)
            {
                descuento = 0.09;
            }
            else if (cantidad  >= 20 && cantidad  < 50)
            {
                descuento = 0.18;
            }
            else
            {
                descuento = 0.25;
            }

            switch (cantidad )
            {
                case int n when n >= 50:
                    Console.WriteLine("El precio total es de $1000.0 pero tienes un descuento del 25%!");
                    break;
                case int n when n >= 20:
                    Console.WriteLine("El precio total es de $1000.0 pero tienes un descuento del 18%!");
                    break;
                case int n when n >= 10:
                    Console.WriteLine("El precio total es de $1000.0 pero tienes un decuento del 9%!");
                    break;
                default:
                    Console.WriteLine("No tienes descuentos.");
                    break;
            }

            double precio = 1000.0;
            double precioConDescuento = precio - (precio * descuento);
            Console.WriteLine($"El precio con descuento es : ${precioConDescuento:F2}");


            //Ejercicio 9 de la Guía 3.2: Clasificación de números Positivos, Negativos o Ceros

            Console.Write("Ingrese un número: ");
            _ = Console.ReadLine();

            if (float.TryParse(input, out float numero))
            {
                switch (numero)
                {
                    case 0:
                        Console.WriteLine("El número ingresado es cero.");
                        break;
                    default:
                        if (numero > 0)
                        {
                            Console.WriteLine("El número ingresado es positivo.");
                        }
                        else
                        {
                            Console.WriteLine("El número ingresado es negativo.");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            }


        }
    }
}
