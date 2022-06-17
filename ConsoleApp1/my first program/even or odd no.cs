using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.my_first_program
{
    class Class3
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number");
            int i= int.Parse(Console.ReadLine());
           
            if (i % 2==0)
                Console.WriteLine("no is even");
            else
                Console.WriteLine("no is odd");

        }
    }
}
