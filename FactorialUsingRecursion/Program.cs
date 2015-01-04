using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialUsingRecursion
{
    class Program
    {
        private static long GetFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number*GetFactorial(number - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number :");
            int number = int.Parse(Console.ReadLine());
            long fact = GetFactorial(number);
            Console.WriteLine("{0} factorial is {1}", number,fact);
            Console.ReadKey();
        }
    }
}
