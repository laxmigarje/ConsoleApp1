using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.String
{
    class String_in_Patterncs
    {
        static void Main(string[] args)
        {
            string str = "I Like India Country";
            string[] s = str.Split(" ");
            for(int i = 0;i<s.Length;i++)
            {
                for(int j = 0; j<i;j++)
                {
                    Console.Write(s[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
