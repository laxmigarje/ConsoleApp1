using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.if_else
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the weight");
            int wt = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                if (wt > 50)
                {
                    Console.WriteLine("allowed to donate blood");
                }
                else
                {
                    Console.WriteLine("age is valid but not weight");
                }
            }
            else
            {
                Console.WriteLine("not allowed");
            }


        }
    }
}
