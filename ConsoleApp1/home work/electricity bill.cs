using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.home_work
{
    class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many units");
            int unit = int.Parse(Console.ReadLine());
            double amt;
            if (unit <= 50)
                amt = 0.50 * unit;
            else if (unit <= 150)
                amt = 100 + ((unit - 50) * 0.75);
            else if (unit <= 250)
                amt = 100 + ((unit - 150) * 1.20);
            else
                amt = 220 + ((unit - 250) * 1.50);

            double surcharge = amt * 0.20;
            double total =amt + surcharge;
            Console.WriteLine("The total bill is "+total);


        }
    }
}
