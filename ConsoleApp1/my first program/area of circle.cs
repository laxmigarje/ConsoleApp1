using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.my_first_program
{
    class Class4
    {
        static void Main(string[] args)
        {
            int r;
            double A;
            Console.WriteLine("Area of circle");
            r= Convert.ToInt32(Console.ReadLine());
            A = (3.14) * r * r;
            Console.WriteLine("The Area of circle of given radius is="+A);
            Console.ReadLine();


        }
    }
}
