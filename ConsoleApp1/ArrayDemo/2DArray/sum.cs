using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ArrayDemo._2DArray
{
    class sum
    {
        static void Main(string[] args)
        {
            int[,] a = { { 3, 4, 5 }, { 1, 6, 7, }, { 3, 2, 1 } };
            for(int i = 0; i<a.GetLength(0);i++)
            {
                int sum = 0;
                for(int j=0; j<a.GetLength(1);j++)
                {
                    sum = sum + a[i, j];
                    Console.Write(a[i,j]+"  ");
                }
                Console.Write("     = "+sum);
                Console.WriteLine();
            }
            
        }
    }
}
