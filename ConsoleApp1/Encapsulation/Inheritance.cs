using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Encapsulation
{
    class Laptop
    {
        protected int price = 45000;
    }  

    class Dell : Laptop
    { 
        public void show()
        {
            price = 35000;
            Console.WriteLine("Dell="+price);
        }


    }
    class Hp : Laptop
    {
        public void display()
        {
            price = 56000;
            Console.WriteLine("Hp="+price);
        }
    }



    class Accer : Laptop
    {
        public void output()
        {
            price = 50000;
            Console.WriteLine("Accer"+price);

        }
    }

    class MyLaptop
    {
        static void Main(string[] args)
        {
            Accer a = new Accer();
            a.output();
            Dell d = new Dell();
            d.show();
            Hp p = new Hp();
            p.display();
        }
    }
}
