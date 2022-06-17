using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.if_else
{
    class Class2
    {
        static void Main(string[] args)
        {
            int character;
            Console.WriteLine("Entre the character");
            char x = char.Parse(Console.ReadLine());

            if (x >= 'A' && x <= 'Z')
            {
                character = x;
                character = character + 32;
                char lower = (char)character;
                Console.WriteLine(lower);
            }
            else
            {
                character = x;
                character = character - 32;
                char upper = (char)character;
                Console.WriteLine(upper);

            }



        }
    }
}


        
    

