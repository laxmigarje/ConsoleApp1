using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Encapsulation
{
    class Student
    {
        private int id;
        private string name;
        private double per;


        public int Id
        {
        get;
            set;
            }

        public string Name
        {
            get;
            set;
        }
        public double Per
        {
            get;
            set;
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 4;
            s.Name = "Abhijit";
            s.Per = 89.67;
            Console.WriteLine(s.Id+" "+ s.Name+" "+s.Per);
        }
    }
}
