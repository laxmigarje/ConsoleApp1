using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.if_else
{
    class Clas4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("Year is Leap Year");
            }

            else
            {
                Console.WriteLine("Year is not Leap Year");
            }




        }
    }
}
        
    

