using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.menu_driven
{
    class Class2
    {
        static void Main(string[] args)
        {
            char ch;

            {
                Console.WriteLine("1.Addition\n 2.Substraction\n 3.Multiplication\n 4.Division\n");
                Console.WriteLine("Enter choice");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number1");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number2");
                int num2 = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition:" + (num1 + num2));
                        break;

                    case 2:
                        Console.WriteLine("Substraction:" + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication:" + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("Division:" + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("wrong input");
                        break;

                }
                Console.WriteLine("Do you want to continue");
                ch = Console.ReadLine()[0];
                while (ch == 'y' || ch == 'Y') ;
            }   
    }
    }
}
