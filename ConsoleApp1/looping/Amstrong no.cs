using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping
{
    class Class12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = 0 , sum = 0;
            temp = num;
            while(temp>0)
            {
                int rem = temp % 10;
                sum = sum + (rem * rem * rem);
                temp = temp / 10;


            }
            if(sum==num)
            {
                Console.WriteLine("Amstrong Number");
            }
            else
            {
                Console.WriteLine("not Amstrong Number");
            }



        }
    }
}
