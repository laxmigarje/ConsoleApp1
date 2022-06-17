using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.assessment_test_1
{
    class Class6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the of side of :\t");
            float side = float.Parse(Console.ReadLine());


            float root = (float)Math.Sqrt(3) / 4;
            float area = root * side * side;

            Console.WriteLine("Area of equilateral Traingle:\t");

        }
    }
}
