using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.series
{
    class Class3
    {
        static void Main(string[] args)
        {
            int n = 1;
            while(n<25)
            {
                if(n%2==0)
                {
                    Console.WriteLine(n);
                }
                else
                    Console.WriteLine(n*n);
                n++;
            }
        }
    }
}
