using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping
{
    class Class2
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i=1; i<=20; i=i+2)
            {
                count++;
            }
            Console.WriteLine("count the total odd no"+count);
        }
    }
}
