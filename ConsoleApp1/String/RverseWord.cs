using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.String
{
    class RverseWord
    {
        static void Main(string[] args)
        {
            string str = "C# is easy";
            string[] str1 = str.Split(" ");
            string reverse = "";
            for(int i = 0;i<str1.Length;i++)
            {
                string word = str1[i];
                string myword = "";
                for(int j = word.Length-1;j>=0;j--)
                {
                    myword = myword + word[j];
                }
                reverse = reverse + myword + " ";
            }
            Console.WriteLine(reverse);
        }
    }
}
