using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.my_first_program
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 number");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("addition="+sum);


        }
    }
}
