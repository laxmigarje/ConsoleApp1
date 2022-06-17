using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.assessment_test_1
{
    class Leap_year
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year");
            int year = int.Parse(Console.ReadLine());
            if(year % 4 == 0)
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("Not leap year");
            }
        }
    }
}
