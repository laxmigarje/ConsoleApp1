using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.series
{
    class Class1
    {
        static void Main(string[] args)
        {
            int num = 1;
            while(num>=1)
            {
                if(num%2==0)
                {
                    int sq = num * num;
                    Console.WriteLine(sq);
                }
                else
                {
                    Console.WriteLine(num);
                    break;
                }
            }

        }
    }
}
