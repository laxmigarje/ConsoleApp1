using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ArrayDemo._2DArray
{
    class TwoDArrayPattern
    {
        static void Main(string[] args)
        {
            int[,] a = { { 5, 4, 3, 3 }, { 7, 8, 1, 6 }, { 9, 2, 3, 4 }, { 3, 5, 1, 9 } };
            for(int i = 0;i<a.GetLength(0);i++)
            {
                for(int j = 0; j<a.GetLength(1);j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("//////////////////////////");
            for(int i =0; i<a.GetLength(0);i++)
            {
                for(int j = 0; j<a.GetLength(1);j++)
                {
                    if(i==0|| j==0 || i==a.GetUpperBound(0) || j==a.GetUpperBound(1))
                    {
                        Console.Write(a[i,j]+" ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
