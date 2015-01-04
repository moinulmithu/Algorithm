using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter a number:");
           int m =int.Parse(Console.ReadLine());
           Console.WriteLine("Square root of {0} is {1}", m, function(m));
           Console.ReadKey();
        }
        static string function(int l)
        {
            decimal x = l;
            for (int i = 0; i < 20; x = (((x * x) + l) / (2 * x)), i++) ;
            return (x.ToString()); 
        }
    }
}
