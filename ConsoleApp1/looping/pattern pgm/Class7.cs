using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.pattern_pgm
{
    /*
     * 
     * * *
     * * * *    */
     
    class Class7
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<=4;i++)
            {
                for(int j=1; j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
