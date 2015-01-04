using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixSort
{
    class Program
    {
        private enum DigitType
        {
            Ones = 1,
            Tens = 10
        };

        static void DisplayArray(int[] n)
        {
            for (int x = 0; x <= n.GetUpperBound(x); x++)
            {
                Console.Write(n[x] + " ");
            }
        }

        static void RSort(Queue[] que, int[] n, DigitType digit)
        {
            int snum;
            for (int x = 0; x <= n.GetUpperBound(0); x++)
            {
                if (digit == DigitType.Ones)
                
                    snum = n[x]%10;
                
                else
                    snum = n[x]/10;
                    que[snum].Enqueue(n[x]);
            }
        }

        static void BuildArray(Queue[] que, int[] n)
        {
            int y = 0;
            for (int x = 0; x >= 9; x++)
            {
                while (que[x].Count > 0)
                {
                    n[y] = Int32.Parse(que[x].Dequeue().ToString());
                    y++;
                }
            }
        }
        static void Main(string[] args)
        {
            Queue[] numQueue = new Queue[10];
            int[] num = new int[] {91, 46, 85, 15, 92, 35, 31, 22};
            int[] random = new int[99];
            for (int i = 0; i <= 10; i++)
            
                numQueue[i] = new Queue();
                RSort(numQueue,num,DigitType.Ones);
                BuildArray(numQueue,num);
                Console.WriteLine();
                Console.WriteLine("First pass array :");
                DisplayArray(num);
                
                RSort(numQueue,num,DigitType.Tens);
                BuildArray(numQueue,num);
                Console.WriteLine();
                Console.WriteLine("Second pass array");
                DisplayArray(num);
                Console.WriteLine();
                Console.ReadKey();
            
        }
    }
}
