using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ternary_operator
{
    class even_odd_no
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            string ans = num > 0 ? "positive" : num < 0 ? "Negative" : "zero";
            Console.WriteLine("Ans="+ans);
        }
    }
}
