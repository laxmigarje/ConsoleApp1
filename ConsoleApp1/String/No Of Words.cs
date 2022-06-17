using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.String
{
    class No_Of_Words
    {
        static void Main(string[] args)
        {
            string str1;
            int a, count;
            str1 = "Hello World!";
            a = 0;
            count = 1;
            while (a <= str1.Length - 1)
            {
                if (str1[a] == ' ' || str1[a] == ' ' || str1[a] == ' ')
                {
                    count++;
                }
                a++;
            }
            Console.WriteLine( count);
        }
    }

}
    



class CountWords2
{
    static void Main(string[] args)
    {
        int a = 0, count = 1;
        string str = "Hello World";

        string[] s = str.Split(" ");

        Console.WriteLine("Number of words=" +s.Length);
    }
}