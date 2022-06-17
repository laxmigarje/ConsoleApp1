using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping
{
    class Class6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no for printing table");
            int no = int.Parse(Console.ReadLine());
            int table;
            for(int i=1; i<=10;i++)
            {
                table = no* i;
                Console.WriteLine(table);
            }
        }
    }
}
