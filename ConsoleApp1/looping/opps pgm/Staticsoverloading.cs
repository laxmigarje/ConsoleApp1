using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.opps_pgm
{
    class Staticsoverloading
    {
        static void calculate(int a, int b)
        {
            Console.WriteLine("Addition=" + (a + b));
        }
        static void calculate(double c, double d)
        {
            Console.WriteLine("Addition=" + (c + d));
        }


        static void Main(string[] args)
        {
            Staticsoverloading.calculate(5, 7);
            Staticsoverloading.calculate(7, 6);

        }


    }
}

class staticAddition
{
    int x = 20;
    static int y = 10;
    void addition()
    {
        Console.WriteLine("Addition="+(x+y));
    }
    static void Division()
    {
        staticAddition s = new staticAddition();
        Console.WriteLine("Division="+(s.x / y));

    }
    static void Main(string[] args)
    {

        staticAddition s1 = new staticAddition();
            s1.addition();

        Division();
    }

    }


















