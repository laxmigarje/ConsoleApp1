using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assesment_Test_4
{
    class ReplaceZeroOne
    {
        static void Main(string[] args)
        {
            int[] arr = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            for(int i = 0;i<arr.Length;i++)
            {
                if(arr[i]==0)
                {
                    arr[i] = 1;
                }
            }
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
