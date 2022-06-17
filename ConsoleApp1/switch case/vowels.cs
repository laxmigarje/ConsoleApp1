using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.switch_case
{
    class vowels
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Character");
            char ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("vowel");
                    break;

                case 'e':
                    Console.WriteLine("vowel");
                    break;

                case 'i':
                    Console.WriteLine("vowel");
                    break;

                case 'o':
                    Console.WriteLine("vowel");
                    break;

                case 'u':
                    Console.WriteLine("vowel");
                    break;


                default:
                    Console.WriteLine("consonent");
                    break;


            }
        }
    }
}
