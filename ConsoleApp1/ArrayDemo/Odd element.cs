using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ArrayDemo
{
    class Odd_element
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 5, 7, 11, 9, 13, 15 };
            for(int i = 0; i<a.Length;i++)
            {
                if(a[i]%2!=0)
                {
                    Console.WriteLine(" "+a[i]);
                }
            }
        }
    }
}
