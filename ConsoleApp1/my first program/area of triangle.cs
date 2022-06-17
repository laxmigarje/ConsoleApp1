using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.my_first_program
{
    class Class7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base of traingle");
            double triangleBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of triangle");
            double triangleheight = Convert.ToDouble(Console.ReadLine());
            double areaoftriangle = (triangleBase * triangleheight) * 0.5;
            Console.WriteLine("Area of traingle is" + areaoftriangle);
            
        }
    }
}
