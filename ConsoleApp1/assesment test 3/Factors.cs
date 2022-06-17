using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.assesment_test_3
{
    class Factors
    {
        static void Main(string[] args)
        {
            int i , n;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factors");

            for(i=1; i<=n; i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine(i);

                }
            }
            Console.ReadLine();
        }
    }
}
