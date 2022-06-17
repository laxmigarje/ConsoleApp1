using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.String
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string str = "India is my country";
            char[]ch = str.ToCharArray();
            int j = ch.Length - 1;
            for(int i= 10;i<ch.Length/2;i++)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                j--;
            }
            
            string st = new string(ch);
            Console.WriteLine(st);
        }
    }
}






/*ReverseStringLogic2*/

class Class1
{
    static void Main(string[] args)
    {
        string str = "India is my country";
        string reverse = "";
        for(int i = 0; i<str.Length;i++)
        {
            reverse = str[i] + reverse;
        }
        Console.WriteLine(reverse);
        

    }
}



/*RverseStringLogic3*/

class Class
{
    static void Main(string[] args)
    {
        string str = "India is my country";
        string reverse = "";
        for(int i = str.Length-1;i>=0;i--)
        {
            reverse = reverse + str[i];
        }

    }
}