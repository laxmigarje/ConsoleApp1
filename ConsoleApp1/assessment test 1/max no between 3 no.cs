using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.assessment_test_1
{
    class Class8
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int max = 0;

            if(num1 > num2 && num1 > num3)
            {
                max = num1;
            }
           else if(num2 > num1 && num2 > num3 )
            {
                max = num2;
            }
            else
            {
                max = num3;
            }

            Console.WriteLine(max);
        }
    }
}
