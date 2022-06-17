using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ternary_operator
{
    class leap_year
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year");
            int num = int.Parse(Console.ReadLine());

            string ans = num % 4 == 0 ? "Leap year" : "Not Leap year";
            Console.WriteLine("year is" +ans);
        }
    }
}
