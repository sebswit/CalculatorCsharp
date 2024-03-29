﻿using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;


                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");


                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Pick an option: ");
                Console.WriteLine("\t+ add");
                Console.WriteLine("\t- substract");
                Console.WriteLine("\t* multiply");
                Console.WriteLine("\t/ divide");
                Console.Write("Enter an option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That is not a valid option");
                        break;
                }
                Console.WriteLine("Continue? (Y/N)");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
