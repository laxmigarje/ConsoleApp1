using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.opps_pgm
{
    class student1
    {
        public int id, marks;
        public string name;

        public student1(int id , string name, int marks)
        {
            this.id = id;
            this.name = name;
            this.marks= marks;

        }
        public void show()
        {
            Console.WriteLine(id +" "+name+" "+marks);
        }
        static void Main(string[] args)
        {
            student1 s1 = new student1(101, "Abhijit", 87);
            student1 s2 = new student1(102, "manisha", 76);
            student1 s3 = new student1(103, "pranali", 92);

            s1.show();
            s2.show();
            s3.show();

        }

    }
}
