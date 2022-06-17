using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ArrayDemo._2DArray
{
    class TwoDArrayCreate
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            for(int i = 0;i<a.GetLength(0);i++)
            {
                for(int j = 0; j<a.GetLength(1);j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine("..................");
            for(int i=0; i<a.GetLength(0);i++)
            {
                for(int j = 0; j<a.GetLength(1);j++)
                {
                    Console.Write(a[i,j]+" ");
                }
            }
        }
    }
}
