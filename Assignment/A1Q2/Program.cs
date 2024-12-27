using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Basic Calculator");
            Console.WriteLine("");

            Console.WriteLine("Enter the choice : \n1. Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            int operation = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Enter the first number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            double result;
            switch (operation)
            {
                case 0:
                    Console.WriteLine("Exiting from program");
                    Environment.Exit(0);
                    break;

                case 1:
                    result = num1 + num2;
                    Console.WriteLine("Result : " + result);
                    break;

                case 2:
                    result = num1 - num2;
                    Console.WriteLine("Result : " + result);
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine("Result : " + result);
                    break;
                case 4:
                    result = num1 / num2;
                    Console.WriteLine("Result : " + result);
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

        }
    }
}
