using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.my_first_program
{
    class Class6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any two numbers for swapping");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("The swaped numbers are:" + a + " " + b);
        }
    }
}
