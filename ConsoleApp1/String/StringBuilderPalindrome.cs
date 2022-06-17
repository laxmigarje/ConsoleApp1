using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.String
{
    class StringBuilderPalindrome
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to Check Palindrome : ");
            string name = Console.ReadLine();
            string reverse = " ";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }

            if (name == reverse)
            {
                Console.WriteLine(" Palindrome");
            }
            else
            {
                Console.WriteLine(" not Palindrome");
            }
            Console.ReadKey();
        }
    }
}
