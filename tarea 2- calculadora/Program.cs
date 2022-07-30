using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_2__calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Double num1 = 0;
            Double num2 = 0;
            // float c = a + b;


            Console.Title = "Programa de calculadora basica \n\n ";

            Console.WriteLine("semana 2 \n");


            Console.WriteLine("Escribe el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Escribe el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());


            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - sumar");
            Console.WriteLine("\ts - restar");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");
            Console.Write("tu opcion elegida? ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Resultado: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Resultado: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Resultado: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Resultado: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Wait for the user to respond before closing.
            Console.Write("Presione cualquier tecla para cerrar");
            Console.ReadKey();
        }
    }
}
