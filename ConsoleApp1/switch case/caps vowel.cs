using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.switch_case
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Character");
            char ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case 'A': Console.WriteLine("vowel");
                    break;

                case 'E': Console.WriteLine("vowel");
                    break;

                case 'I': Console.WriteLine("vowel");
                    break;

                case 'O': Console.WriteLine("vowel");
                    break;

                case 'U': Console.WriteLine("vowel");
                    break;


                default: Console.WriteLine("consonent");
                    break;


            }

        }
    }
}
