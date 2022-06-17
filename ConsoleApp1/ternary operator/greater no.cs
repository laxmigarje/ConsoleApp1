using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ternary_operator
{
    class greater_no
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number3");
            int num3 = int.Parse(Console.ReadLine());
            string ans = num1 > num2 ? (num1 > num3) ? "num1 is geater" : "num3 is greater" : num2 > num3 ? "num2 is greater" : "num3 is greater" ; 
            Console.WriteLine(ans);
        }
    }
}
