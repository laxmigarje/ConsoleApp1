using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Encapsulation
{
    class hirachical_inheritance
    {
        class Program
        {
            static void Main(string[] args)
            {
                Principal g = new Principal();
                g.Monitor();
                Teacher d = new Teacher();
                d.Monitor();
                d.Teach();
                Student s = new Student();
                s.Monitor();
                s.Learn();
                Console.ReadKey();
            }
            class Principal
            {
                public void Monitor()
                {
                    Console.WriteLine("Monitor");
                }
            }
            class Teacher : Principal
            {
                public void Teach()
                {
                    Console.WriteLine("Teach");
                }
            }
            class Student : Principal
            {
                public void Learn()
                {
                    Console.WriteLine("Learn");
                }
            }
        }
    }
}







class Vehical
{
    public virtual void run()
    {
        Console.WriteLine("vehical is running");
    }
}

class Car : Vehical
{
    public override void run()
    {
        Console.WriteLine("Car is running");
        
    }
}

class Truck : Vehical
{
    public override void run()
    {
        Console.WriteLine("Truck is running");

        
    }
}



class OverridingDemo
{
    static void Main(string[] args)
    {
        Car c = new Car();
        c.run();
        Vehical v = new Car();
        v.run();
    }
}




  