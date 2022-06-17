using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.digits
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while(num>0)
            {
                int rem = num % 10;
                count++;
                num = num / 10;

            }
            Console.WriteLine("Number is"+count+" Digit");

        }
    }
}
