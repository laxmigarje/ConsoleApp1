using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.home_work
{
    class cube
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no to check ==>");
            int no = int.Parse(Console.ReadLine());


            int cube = no * no * no;

            while(no>0)
            {
                if (no % 10 != cube % 10 )
                {
                    no = no / 20;
                    cube = cube / 10;
                }
            }
        }
    }
}
