using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num, fact;
            Console.WriteLine("Input a number");
            num = int.Parse(Console.ReadLine());
            fact = num;
            for (i = num - 1; i>= 1; i--)
            {
                fact = fact*i;
            }
            Console.WriteLine("The factorial is =" + fact);
            Console.ReadKey();

        }
    }
}

