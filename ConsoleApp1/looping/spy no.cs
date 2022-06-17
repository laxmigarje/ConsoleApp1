using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping
{
    class Class13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum= 0, mul = 1;
            while(num>0)
            {
                int rem = num % 10;
                sum = sum + rem;
                mul = mul * rem;
                num = num / 10;


               
            }
            if(sum==mul)
            {
                Console.WriteLine("This is spy number");
            }
            else
            {
                Console.WriteLine("This number is not spy number");
            }
        }
    }
}
