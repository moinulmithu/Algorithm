using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class MergeSortArray
    {
        void MergeArray(int[] arr, int start, int mid, int end)
        {
            int[] temp = new int[end-start+1];
            int i = start;
            int j = mid + 1;
            int k = 0;
            while (i <= mid && j<=end)
            {
                if (arr[i] < arr[j])
                {
                    temp[k] = arr[i];
                    k++;
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    k++;
                    j++;
                }
            }
            while (i <= mid)
            {
                temp[k] = arr[i];
                k++;
                i++;
            }
            while (j<= end)
            {
                temp[k] = arr[j];
                k++;
                j++;
            }
            k = 0;
            i = start;
            while (k <= temp.Length && i <= end)
            {
                arr[i] = temp[k];
                i++;
                k++;
            }
        }

        void MergeSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end)/2;
                MergeSort(arr,start,mid);
                MergeSort(arr,mid+1,end);
                MergeArray(arr,start,mid,end);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {2, 15, 10, 14, 5, 8, 9, 17, 19, 22, 45};
            
            MergeSortArray merge = new MergeSortArray(); 
            merge.MergeSort(arr,0,arr.Length-1);
            foreach (int a in arr)
            {
                Console.WriteLine(a + "");
            }
            Console.ReadKey();

        }
    }
}
