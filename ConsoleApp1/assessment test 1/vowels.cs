using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.assessment_test_1
{
    class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any character");
            char ch = char.Parse(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                Console.WriteLine(ch + "is an vowel");
            else
                Console.WriteLine(ch + "is not a vowel");

        }
    }
}
    

