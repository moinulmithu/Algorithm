using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRootUsingSqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            int Number = int.Parse(Console.ReadLine());
            double SqNumber = Math.Sqrt(Number);
            Console.WriteLine("Square root of {0} is {1}",Number,SqNumber);
            Console.ReadKey();
        }
    }
}
