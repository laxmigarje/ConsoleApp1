using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping
{
    class Class8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the base");
            int bas = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the power");
            int pow = int.Parse(Console.ReadLine());
            int count = 1;
            for(int i =1; i<=pow; i++)
            {
                count = count * bas
;
            }
            Console.WriteLine("result is "+count);
        }
    }
}
