using System;
using System.Runtime.ExceptionServices;

namespace calculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primer Numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo Numero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elige operacion: +,-,*,/");
            string operacion = Console.ReadLine();
            double result;

            switch (operacion)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("No se puede dividir por cero");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
                    }
                    break;
                default:
                    Console.WriteLine("Operacion invalida");
                    break;
            }

        }
    }
}