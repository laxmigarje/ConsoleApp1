using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.assesment_test_3
{
    class HarshadNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = 0, sum = 0;
             temp = num;
            while(temp>0)
            {
                int rem = temp % 10;
                sum = sum + rem;
                temp = temp / 10;


            }
            if (num%sum==0)
            {
                Console.WriteLine("Harshad Number");
            }
            else
            {
                Console.WriteLine("Non Harshad Number");
            }
        }
    }
}
