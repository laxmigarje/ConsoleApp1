using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping
{
    class Class11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0, temp;
            temp = num;
            while(temp>0)
            {
                int rem = temp % 10;
                reverse = (reverse * 10) + rem;
                temp = temp / 10;

            }
            if(num==reverse)
            {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is not palindrome");
            }
        }
    }
}
