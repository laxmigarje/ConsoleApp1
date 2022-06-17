using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.String
{
    class ToggleCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            string newstr = "";
            for(int i = 0;i<str.Length;i++)
            {
                char ch = str[i];
                if(ch>='A' && ch<='Z')
                {
                    ch = (char)(ch + 32);

                }
                else 
                {
                    ch = (char)(ch - 32);
                }
                newstr = newstr + ch;
            }
            Console.WriteLine(newstr);
        }
    }
}
