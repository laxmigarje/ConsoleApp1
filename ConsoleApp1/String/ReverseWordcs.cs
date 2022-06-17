using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.String
{
    class ReverseWordcs
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();
            string reverseString = " ";
            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                reverseString += originalString[i];
            }
            Console.Write("Reverse String is : {reverseString} ");
            Console.ReadLine();
        }
    }
}
        


    

