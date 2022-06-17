using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.opps_pgm
{
    class constructorovr
    {
        public constructorovr()
        {
            Console.WriteLine("Car Information");
        }
        public constructorovr(int module)
            
            {
            Console.WriteLine("Module"+module);

        }
        public constructorovr(string name)
        {
            Console.WriteLine("Name"+name);
        }
        public constructorovr(double price)
            {
            Console.WriteLine("Price"+price);

        }
        static void Main(string[] args)
        {
            constructorovr c = new constructorovr();
            constructorovr c1 = new constructorovr(200);
            constructorovr c2= new constructorovr("xylo");
            constructorovr c3 = new constructorovr(550000);
        }
        
        

        
    }
}
