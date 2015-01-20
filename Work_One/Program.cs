using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_One
{
    class Program
    {
        private static bool IsPrimeNumber(int num)
        {
            bool isPrime = true;
            int factor = num/2;
            int i = 0;
            for (i = 2; i <= factor; i++)
            {
                if ((num%i) == 0)
                    isPrime = false;
            }
            return isPrime;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Prime number between 0 to n is below");
            for (int i = 0; i <= 10; i++)
            {
                if(IsPrimeNumber(i) == true)
                    Console.Write(i);
            }
            Console.ReadKey();
        }
    }
}
