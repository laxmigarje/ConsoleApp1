using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.opps_pgm
{
    class student
    {
        int stuid;
        string studname;
        int english;
        int math;
        int science;
        float perc;


        public void studdemo()
        {
            Console.WriteLine("Enter student id");
            stuid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student name");
            studname = Console.ReadLine();
            Console.WriteLine("Enter marks of English");
            english = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks of math");
            math = int.Parse(Console.ReadLine());

        }
        public void percentage()
        {
            perc = ((english + math + science) / 3);

        }
        public void display()
        {
            Console.WriteLine();
            Console.WriteLine("student ID" + stuid);
            Console.WriteLine("student Name"+ studname);
            Console.WriteLine("English marks" +english);
            Console.WriteLine("math marks"+ science);
            Console.WriteLine("percetage"+perc);
        }
        static void Main(string[] args)
        {
            student s = new student();
            s.studdemo();
            s.percentage();
            s.display();
            Console.WriteLine();

        }
    }
}
