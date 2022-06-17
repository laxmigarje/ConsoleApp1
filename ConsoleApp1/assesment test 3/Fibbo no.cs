using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.assesment_test_3
{
    class Fibbo_no
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, sum = 0, n = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            while(n<20)
            {
                sum = a + b;
                a = b;
                b = sum;
                n++;
                Console.WriteLine(sum);





            }
        }
    }
}
