using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing variables
            int num1 = 9;
            int num2 = 6;
            //creating the math variables
            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            int quotient = num1 / num2;
            int remainder = num1 % num2;

            //console prints
            Console.WriteLine(sum);
            Console.WriteLine(difference);
            Console.WriteLine(product);
            Console.WriteLine(quotient);
            Console.WriteLine(remainder);

            //creating bool
            bool isNum1Greater = num1 > num2;
            Console.WriteLine(isNum1Greater);

        }
    }
}