using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ArrayDemo
{
    class ArrayReverseDemo
    {
        static void Main(string[] args)
        {
            char[] ch = { 'e', 't', 'u', 'd', 'n' };
            Console.WriteLine();
            Console.WriteLine("///////////////////");
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", ch));
            Console.WriteLine();
            
            for(int i = 0;i<ch.Length;i++)
            {
                Console.WriteLine(ch[i]);
                
                
             
            }
        }
    }
}
