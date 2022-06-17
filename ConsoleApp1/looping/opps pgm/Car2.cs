using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.opps_pgm
{
    class Car2
    {
        int model_no;
        string name;
        string colour;
        int prize;
        string cname;

        public void input(int model_no, string name, string color, int prize)
        {
            this.model_no = model_no;
            this.name = name;
            this.colour = color;
            this.prize = prize;

        }
        void show()
        {
            this.input(102, "audi", "white", 3000000);
            Console.WriteLine(model_no);
            Console.WriteLine(name);
            Console.WriteLine(colour);
            Console.WriteLine(prize);
        }
        public Car2(string cname)
        {
            this.cname = cname;
            display();
        }
        public void display()
        {
            Console.WriteLine(cname);
        }
        public Car2() : this("Breszza")
        {
            Console.WriteLine("I am the default constructor");
        }
        static void Main(string[] args)
        {
            Car2 c1 = new Car2();
            c1.show();

        }

    }
}
        


        

        


    

