using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.series
{
    class Class2
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sq, cube, total;
            while(num>=1)
            {
                sq = num * num;
                cube = num * num * num;
                total = sq + cube;
                Console.WriteLine(total+" ");
                num++;
                if(num==10)
                {
                    break;
                }
            }
        }
    }
}
