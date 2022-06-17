using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.pattern_pgm
{
   /* 1
    2 3
    4 5 6
    7 8 9 10*/
    class Class6
    {
        static void Main(string[] args)
        {
            int count = 1;
            for(int i = 1; i<=10; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(" " + count);
                count ++;
            }
            Console.WriteLine();
            

            

        }
    }
}
