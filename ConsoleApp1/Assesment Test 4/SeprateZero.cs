using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assesment_Test_4
{
    class SeprateZero
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 0, 7, 0, 8, 0, 3 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j]) ;
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("seprate zero");
        }
    }
}


