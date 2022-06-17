using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.String
{
    class StringAnagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st string");
            string s = Console.ReadLine();
            Console.WriteLine("Enter 2nd string");
            string s1 = Console.ReadLine();


            string st1 = s.ToLower();
           string st2 = s1.ToLower();

            char[] ch1 = st1.ToCharArray();
            char[] ch2 = st2.ToCharArray();

            Console.WriteLine(string.Join(" ",ch1));
            Console.WriteLine(string.Join(" ",ch2));
            Array.Sort(ch1);
            Array.Sort(ch2);
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine(string.Join(" ", ch1));
            Console.WriteLine(string.Join(" ", ch2));

            string str1 = new string(ch1);
            string str2 = new string(ch2);

            if(str1.Equals(str2))
            {
                Console.WriteLine("String is Anagram");
            }
            else
            {
                Console.WriteLine("String is not Anagram");
            }

        }
    }
}






class StringAnagram2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 1st string");
        string s = Console.ReadLine();
        Console.WriteLine("Enter 2nd string");
        string s1 = Console.ReadLine();


        string st1 = s.ToLower();
        string st2 = s1.ToLower();

        char[] ch1 = st1.ToCharArray();
        char[] ch2 = st2.ToCharArray();

        if (ch1.Length == ch2.Length)
        {
            Console.WriteLine(string.Join(" ", ch1));
            Console.WriteLine(string.Join(" ", ch2));
            Array.Sort(ch1);
            Array.Sort(ch2);
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine(string.Join(" ", ch1));
            Console.WriteLine(string.Join(" ", ch2));

            bool flag = true;


            for (int i = 0; i < ch1.Length; i++)
            {
                if (ch1[i] != ch2[i])
                {
                    flag = false;
                    break;
                }

            }
            if (flag == true)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }

        }
    }
}

        

