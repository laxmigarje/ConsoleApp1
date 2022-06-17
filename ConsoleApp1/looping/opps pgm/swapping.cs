using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.opps_pgm
{
    class swapping
    {
        void swap(int num1,int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1+"   "+num2);

            swapping s = new swapping();
            s.swap(num1, num2);
            Console.WriteLine("After swapping");
            Console.WriteLine(num1+" "+num2);







           

        }


    }
}
