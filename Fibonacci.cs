using System;

namespace ConsoleApp1
{
    class Fibonacci : Constants
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the fibonacci number you want:");
            int fibonacci_n = Convert.ToInt32(Console.ReadLine());
            getFibonacciNumber(fibonacci_n);
            Console.WriteLine("The " + fibonacci_n + "th fibonacci number is " + sum);
        }
        private static int getFibonacciNumber(int fibonacci_n)
        {
            for (int i = 0; i < fibonacci_n; i++)
            {
                sum = first_number + second_number;
                first_number = second_number;
                second_number = sum;
            }
            return sum;
        }
    }
}
