using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.class_Practice
{
    class EvenAvgcs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            int avg = 0;
            while (num > 0)
            {
                int dig = num % 10;

                if (dig % 2 == 0)
                {
                    sum = sum + dig;
                    count++;
                }
                avg = sum / count;
                num = num / 10;
            }

            Console.WriteLine("Average of even digits from number is =" + avg);
        }
    }
}

