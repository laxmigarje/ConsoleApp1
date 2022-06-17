using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Zobin_test
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n%2!=0)

            {
                Console.WriteLine("Weird");
            }
            else if(n%2==0 && n>=2 && n<=5 )
            {
                Console.WriteLine("Not Weird");
            }
            else if(n%2==0 && n>=6 && n<=20)
            {
                Console.WriteLine("Weird");
            }
            else if(n%2==0 && n>=20)
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
