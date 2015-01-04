using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPyramid
{
    class Program
    {
        private static void Main(string[] args)
        {
            



                for (int i = 0; i < 10; i++)
                {
                    for (int j = i; j < i; j++)
                    {
                        Console.Write("");
                    }
                    for (int k = i*2 + 1; k > 0; k--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                    Console.ReadKey();
                }
            }
        }
    }

