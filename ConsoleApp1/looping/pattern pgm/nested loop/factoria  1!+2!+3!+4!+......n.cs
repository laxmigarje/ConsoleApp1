using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.pattern_pgm.nested_loop
{
    class factorial
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i =1; i<=5; i++)
            {
                int fact = 1;
                for(int j=1; j<=i; j++)
                {
                    fact = fact * j;
                }
                sum = sum + fact;

            }
            Console.WriteLine(sum);
        }
    }
}
