using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.home_work
{
    class Class8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int count = 0;
            while(num>0)
                {
                count++;
                num = num / 10;

            }
            Console.WriteLine(count);
            num = temp;
            int sum = 0;
            while(num>0)
            {
                int r = num % 10;
                int power = 1;
                for(int i= 1;i<=count;i++)
                {
                    power = power * r;

                }
                sum = sum + power;
                count--;
                num = num / 10;
                for(int i =1; i<count;i++)
                {
                    power = power * r;
                }
                sum = sum + power;
                count++;
                num = num / 10;

            }
            num = temp;
            if(num==sum)
            {
                Console.WriteLine("Disarium");

            }
            else
            {
                Console.WriteLine("Not Disarium");
            }
        }
    }
}
