using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSort
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the number of terms: \n");
                int size = int.Parse(Console.ReadLine());
                int[] arr = new int[size];
                Console.WriteLine("\nEnter the array elements: \n");
                for (int i = 0; i < size; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                MergeSort(arr);
                Console.WriteLine("\nAfter sorting the array: \n");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Number!");
            }
            Console.ReadLine();
        }

        private static int[] MergeSort(int[] arr)
        {
            int len = arr.Length;
            if(len < 2)
            {
                return arr;
            }
            int mid = len / 2;
            int[] left = new int[mid];
            int[] right = new int[len - mid];
            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }
            for (int i = mid; i < len; i++)
            {
                right[i - mid] = arr[i];
            }
            MergeSort(left);
            MergeSort(right);
            Merge(left, right, arr);
            return arr;
        }

        private static int[] Merge(int[] left, int[] right, int[] arr)
        {
            int lLen = left.Length;
            int rLen = right.Length;
            int i = 0, j = 0, k = 0;
            while (i < lLen && j < rLen)
            {
                if (left[i] < right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < lLen)
            {
                arr[k] = left[i];
                k++;
                i++;
            }
            while (j < rLen)
            {
                arr[k] = right[j];
                k++;
                j++;
            }
            return arr;
        }
    }
}
