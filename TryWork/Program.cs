// See https://aka.ms/new-console-template for more information
using System;
using System.Transactions;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Simple Calculator====");
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Choose operation(+,-,/,*): ");
            char op = Console.ReadKey().KeyChar;//to choose operator
            double result;

            Console.WriteLine();

            //if condition for  a simple calculator

            if (op == '+') {
                result = num1 + num2;

                
            }
            else if( op == '-')
            {
                result = num1 - num2;
                
            }
            else if( op == '*')
            {
                result = num1 * num2;
                
            }
            else if( op == '/')
            {   
                if (num2 != 0) { 
                    result = num1 / num2; 
                }
                else
                {
                    Console.WriteLine("Number cannot be divided by zero");
                    return;
                }   
            }
            else
            {
                Console.WriteLine("Error! Invalid operator");
                return;
            }

            Console.WriteLine("Result = " + result + "\n");
            




           


             
        

        }
    }
}

