using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.class_Practice
{
    class AssendingdesendingArray
    {
        static void PrintOrder(int[]arr,int n)
        {

            Array.Sort(arr);



            for (int i = 0; i < n / 2; i++)
                Console.Write(arr[i] + " ");



            for (int j = n - 1; j >= n / 2; j--)
                Console.Write(arr[j] + " ");
        }


        public static void Main()
        {
            int[] arr = { 5, 4, 6, 2, 1, 3, 8, 9, 7 };
            int n = arr.Length;

            PrintOrder(arr, n);
        }
    }
}

  