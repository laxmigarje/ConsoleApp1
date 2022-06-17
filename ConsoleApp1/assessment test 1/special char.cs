using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.assessment_test_1
{
    class Class4
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter any character:");
            ch = char.Parse(Console.ReadLine());
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + "is an Alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + "is a Digit");
            }
            else
            {
                Console.WriteLine(ch + "is a special character");
            }
        }
    }
} 

        
    

