using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {

                int operation;
                double result;
            do
            {
                Console.WriteLine("This Calculator is made using Function");
                Console.WriteLine("");


                Console.WriteLine("Enter the choice : \n0. Exit\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
                operation = Convert.ToInt32(Console.ReadLine());

                if (operation == 0)
                {
                    Console.WriteLine("Exiting from program !!!!");
                    break;  
                }
               
                Console.WriteLine("Enter the num1 : ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the num2 : ");
                int num2 = Convert.ToInt32(Console.ReadLine());


                switch (operation)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine("Result : " + result);
                        break;
                    case 2:
                        result = num1 - num2;
                        Console.WriteLine("Result : " + result);
                        break;
                    case 3:
                        result = num1 *  num2;
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
            while (operation != 0);


        }
    }
}
