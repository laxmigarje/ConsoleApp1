using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.my_first_program
{
    class Class5
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter length and breadth");
            int l = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int peremeter = 2 * l + b;
            Console.WriteLine("peremeter"+(2*l+b ));
            
        }
    }
}
