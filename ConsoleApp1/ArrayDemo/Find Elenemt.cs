using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ArrayDemo
{
    class Find_Elenemt
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 4, 2, 9, 1 };
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine("Enter number for search");
            int num = int.Parse(Console.ReadLine());
            bool ispresent = false;
            for(int i= 0; i<a.Length;i++)
            {
                if(a[i]==num)
                {
                    ispresent = true;
                    break;
                }
            }
            if(ispresent==true)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Not present");
            }
        }
    }
}
