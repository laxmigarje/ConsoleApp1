using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.String
{
    class ToggleCase2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            string newstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (Char.IsUpper(ch))
                {
                    ch = (char)(ch + 32);

                }
                else if (Char.IsLower(ch))
                {
                    ch = (char)(ch - 32);
                }
                newstr = newstr + ch;
            }
            Console.WriteLine(newstr);
        }
        }
}





 class ToggleCase3
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the string");
        string str = Console.ReadLine();
        string newstr = "";
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if (Char.IsUpper(ch))
            {
                ch = Char.ToLower(ch);

            }
            else if (Char.IsLower(ch))
            {
                ch =Char.ToUpper(ch);
            }
            newstr = newstr + ch;
        }
        Console.WriteLine(newstr);
    }
}




    

