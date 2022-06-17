using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.assesment_test_3
{
    class no_1_to_50
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Even numbers");
            for (i= 1; i<=50;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i+" ");
                }

            }
            Console.WriteLine("Odd numbers");
            for(i=1; i<=50;i++)
            {
                if(i%2!=0)
                {
                    double sqr = Math.Pow(i, 2);
                    Console.WriteLine("square of{0}is{1}", i, sqr);

                }
            }
            Console.WriteLine();
        }
    }
}
