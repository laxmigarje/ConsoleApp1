using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.home_work
{
    class sum
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter two numbers");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int sum = 0;
             sum = n1 + n2;
            Console.WriteLine("sum="+sum);

        }
    }
}
