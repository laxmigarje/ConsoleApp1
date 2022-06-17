using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assesment_Test_4
{
    class PerfectSquare
    {
        static void perfectSquares(int l, int r)
        {

            
            for (int i = l; i <= r; i++)
            {

                
                if (Math.Sqrt(i) == (int)Math.Sqrt(i))
                    Console.Write(i + " ");
            }
        }

        
        public static void Main()
        {
            int l = 2, r = 24;
            perfectSquares(l, r);
        }
    }

}

