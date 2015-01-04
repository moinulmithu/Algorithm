using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] a = new int[100];
            Console.WriteLine("Input the array number");
            string s = Console.ReadLine();
            int x = int.Parse(s);
            Console.WriteLine("=============================");
            Console.WriteLine("\n Enter arry elements\n");
            for (int i = 0; i < x; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = int.Parse(s1);
            }
            Console.WriteLine("=========================");
            Console.WriteLine("Enter search element\n");
            string s2 = Console.ReadLine();
            int x2 = int.Parse(s2);
            for (int i = 0; i < x; i++)
            {
                if (a[i] == x2)
                {
                    Console.WriteLine("==========================");
                    Console.WriteLine("Search successfull");
                    Console.WriteLine("Element {0} found at location {1}", x2, i + 1);
                    return;
                }
                else
                {
                    Console.WriteLine("Search Failed");
                    Console.ReadKey();
                }
            }
            Console.ReadKey();

        }
    }
}
