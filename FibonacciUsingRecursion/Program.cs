using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciUsingRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number  :");
            int number = int.Parse(Console.ReadLine());
            for (int counter = 0; counter < number; counter++)
            {
                Console.WriteLine(Fibonacci(counter));
                Console.ReadKey();
            }
        }

        public static int Fibonacci(int number)
        {
            if (number == 0)
                return 0;
            else if (number == 1)
                return 1;
            else
            {
                return Fibonacci(number - 2) + Fibonacci(number - 1);
            }
        }
    }
    
}
