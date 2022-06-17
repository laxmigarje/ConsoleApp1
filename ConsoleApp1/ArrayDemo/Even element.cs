using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ArrayDemo
{
    class Even_element
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 6, 2, 8 };
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i]%2==0)
                {
                    Console.WriteLine(" "+a[i]);
                }
            }
        }
    }
}
