using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.switch_case
{
    class Even_odd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case 1: Console.WriteLine("number is even"+(num%2==0));
                    break;
                default: Console.WriteLine("number is odd:"+num);
                    break;
            }
        }
    }
}
