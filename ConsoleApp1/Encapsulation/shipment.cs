using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Encapsulation
{
    class Mydate
    {
        private int dd;
        private int mm;
        private int yy;


        public int Dd
        {
            get;
            set;
        }
        public int Mm
        {
            get;
            set;
        }
        public int Yy
        {
            get;
            set;
        }




    }


    class order
    {
        private int id;
        private string custname;
        private int price;
        private string city;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Custname
        {
            get { return custname; }
            set { custname = value; }
        }
        public int Price

        {
            get { return price; }
            set { price = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }



        class Shipment
        {
            private int id;
            order or;
            Mydate dt;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }
            public order Or
            {
                get;
                set;

            }
            public Mydate Dt
            {
                get { return dt; }
                set { dt = value; }
            }

            static void Main(string[] args)
            {
                Shipment s = new Shipment();
                s.Id = 1010;

                s.Or = new order();
                s.Or.Id = 10;
                s.Or.Custname = "maahi";
                s.Or.Price = 1000;
                s.Or.City = "pune";


                s.Dt = new Mydate();
                s.Dt.Dd = 2;
                s.Dt.Mm = 8;
                s.Dt.Yy = 2020;

                Console.WriteLine(s.Id + " " + s.Or.Id + " " + s.Or.Custname + " " + s.Or.Price + " " + s.Or.City + " " + s.Dt.Dd );

            }
        }
    }
}


    

