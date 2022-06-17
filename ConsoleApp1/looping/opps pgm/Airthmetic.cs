using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.opps_pgm
{
    class Airthmetic
    {
        void calculate(int a , int b , int c)
        {
            Console.WriteLine("Addition is"+(a+b+c));

        }
        void calculate (int a , int b)
        {
            Console.WriteLine("Substraction is"+(a-b));
        }
        void caculate(int a, double b)
        {
            Console.WriteLine("multiplication is" + (a * b));

        }
        void calculate(int a,double b)
        {
            Console.WriteLine("Addition is" +(a/b));
        }
        static void Main(string[] args)
        {
            Airthmetic a = new Airthmetic();
            a.calculate(1, 2, 3);
            a.calculate(2, 1);
            a.calculate(5, 5);
            a.calculate(50, 5);


        }


        
    }
}
