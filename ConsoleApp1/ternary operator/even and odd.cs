using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ternary_operator
{
    class even_and_odd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            string ans = num % 2 == 0 ? "number is even" : "number is odd";
            Console.WriteLine("numberis :"+ans);
        }
    }
}
