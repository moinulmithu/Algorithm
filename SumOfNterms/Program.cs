using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNterms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using while loop

            Console.WriteLine("Enter the Nth number");
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int sum = 1;
            while (num < n )
            {
                num++;
                sum += num;
            }
            

            // Using for Loop

            //int i, sum = 0, num;
            //Console.WriteLine("Input the Nth number");
            //num = int.Parse(Console.ReadLine());
            //for (i = 0; i <= num; i ++)
            //{
            //    sum += i;

            //}
            Console.WriteLine("The sum =" + sum);
            Console.ReadKey();
        }
    }
}
