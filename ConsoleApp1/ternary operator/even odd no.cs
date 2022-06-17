using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ternary_operator
{
    class class_6 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            string ans = num % 2 == 0 ? " the number is even" : "the number is odd" ;
            Console.WriteLine("Ans=" +ans);

        }
    }
}
