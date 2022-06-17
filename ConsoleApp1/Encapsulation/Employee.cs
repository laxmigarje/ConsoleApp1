using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Encapsulation
{
    class Employee
    {
        private int id;
        private string name;
        private int salary;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }



        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Id = 200;
            e.Name = "Abhijit";
            e.Salary = 40000;
            Console.WriteLine(e.Id+" "+e.Name+" "+e.Salary);

        }
       
        
            

     }

      
    }

