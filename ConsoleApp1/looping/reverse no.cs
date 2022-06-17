using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping
{
    class Class10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            while (num>0)
            {
                int rev = num % 10;
                reverse = (reverse * 10) + rev;
                num = num / 10;

            }
            Console.WriteLine("Reverse is"+reverse);
        }
    }
}
