using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ArrayDemo
{
    class Alternate_element
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of an Array");
            int x = int.Parse(Console.ReadLine());
            int[] a = new int[x];
            Console.WriteLine("Enter array element");
            for(int i = 0; i<a.Length; i++)
            {
                int e = int.Parse(Console.ReadLine());
                a[i] = e;
            }
            Console.WriteLine("Array elements are");
            foreach(int ele in a)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Alternate array elements are");
            for(int i = 0; i<a.Length; i = i+2)
            {
                Console.WriteLine(a[i]);
                    
            }
        }
    }
}
