using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_One_Two
{
    class Program
    {
        public static bool IsPrimeNumber(int num)
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
            Console.WriteLine("Prime numbers are: ");
            for (int i = 0; i <= 10; i++)
            {
                if (IsPrimeNumber(i) == true)

                    Console.Write(i);
            }
            Console.ReadKey();
            }
        }
    }

