using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.switch_case
{
    class days
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Character");
            char ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case '1':
                    Console.WriteLine("monday");
                    break;

                case '2':
                    Console.WriteLine("tuesday");
                    break;

                case '3':
                    Console.WriteLine("wendsday");
                    break;

                case '4':
                    Console.WriteLine("thursday");
                    break;

                case '5':
                    Console.WriteLine("fraiday");
                    break;

                case '6':
                    Console.WriteLine("saturday");
                    break;


                default:
                    Console.WriteLine("sunday");
                    break;


            }
        }
    }
}
