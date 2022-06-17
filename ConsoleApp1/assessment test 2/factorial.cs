using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.assessment_test_2
{
    class factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                int fact = 1;
                for (int j = 1; j <= 1; j++)
                {
                    fact = fact * j;
                }
                sum = sum + fact;

            }
            Console.WriteLine(sum);
        }
    }
}

        
    

