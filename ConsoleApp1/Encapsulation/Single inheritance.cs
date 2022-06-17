using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Encapsulation
{
    class Single_inheritance
    {
        static void Main(string[] args)
        {
            
            Father f = new Father();
            f.Display();
           
            Son s = new Son();
            s.Display();
            s.DisplayOne();

            Console.ReadKey();
        }
        class Father
        {
            public void Display()
            {
                Console.WriteLine("Display");
            }
        }
        class Son : Father
        {
            public void DisplayOne()
            {
                Console.WriteLine("DisplayOne");
            }
        }
    }
}




class Man
{
    public string name;
    public int age;
    public Man(int age, string name)
    {
        this.name = name;
        this.age = age;
    }
}

class Employee : Man
{
    public int emp_id;
    public int emp_salary;

    public Employee(int id, int salary, string name, int age) : base(age, name)
    {
        emp_id = id;
        emp_salary = salary;
    }
    public void Print()
    {
        Console.WriteLine("Emp ID:      " + emp_id);
        Console.WriteLine("Emp Name:    " + name);
        Console.WriteLine("Emp Salary:  " + emp_salary);
        Console.WriteLine("Emp Age:     " + age);
    }
    static void Main(string[] args)
    {
        Employee emp = new Employee(101, 1000, "Rahul", 31);
        emp.Print();
    }
}




class Rectangle
{

    
    protected double length;
    protected double width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }
    public double GetArea()
    {
        return length * width;
    }
    public void Display()
    {
        Console.WriteLine("Length: {0}", length);
        Console.WriteLine("Width: {0}", width);
        Console.WriteLine("Area: {0}", GetArea());
    }
}
class Tabletop : Rectangle
{
    private double cost;
    public Tabletop(double l, double w) : base(l, w) { }

    public double GetCost()
    {
        double cost;
        cost = GetArea() * 70;
        return cost;
    }
    public void Display()
    {
        base.Display();
        Console.WriteLine("Cost: {0}", GetCost());
    }
}
class ExecuteRectangle
{
    static void Main(string[] args)
    {
        Tabletop t = new Tabletop(4.5, 7.5);
        t.Display();
        Console.ReadLine();
    }
}

