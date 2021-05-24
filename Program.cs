using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num0 = 0;
            double num1 = 0;

            Console.WriteLine("Welcome to my Calculator");
            Console.WriteLine("Please Enter the first number:");
            num0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            // string sum;
            // string div;
            // string min;
            // string mul;
            
            Console.WriteLine("Please enter operation:");
            var op = Console.ReadLine();


            if (op == "sum")
            {
                Console.WriteLine($"The Result of {num0} {op} {num1} is: " + (num0+num1));
            }
            else if (op == "min")
            {
                Console.WriteLine($"The Result of {num0} {op} {num1} is: " + (num0-num1));
            }
            else if (op == "div")
            {
                Console.WriteLine($"The Result of {num0} {op} {num1} is: " + Math.Round((num0/num1),4));
            }
            else if (op == "mul")
            {
                Console.WriteLine($"The Result of {num0} {op} {num1} is: " + Math.Round((num0*num1),4));
            }
        }
    }
}
