using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.home_work
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length");
            float P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rate of intrest");
            float r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the time in year");
            float t = Convert.ToInt32(Console.ReadLine());
            float si;
            si = (P * r * t) / 100;
            Console.WriteLine("simple intrest is " + si);
        }
    }
}
