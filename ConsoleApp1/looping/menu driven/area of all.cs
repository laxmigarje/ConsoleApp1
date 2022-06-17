using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.menu_driven
{
    class Class1
    {
        static void Main(string[] args)
        {
            char ch;
            
            {



                Console.WriteLine("Area of calculation");
                Console.WriteLine("1.circle\n 2.Rectangle\n 3.Traingle\n 4.square\n");
                Console.WriteLine("Enter youe choice");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number1");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number2");
                int num2 = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Area of circle:" + (3.14f * num1 * num2));
                        break;


                    case 2:
                        Console.WriteLine("Area of Reactangle:" + (num1 * num2));
                        break;

                    case 3:
                        Console.WriteLine("Area of Traingle:" + (0.5 * num1 * num2));
                        break;

                    case 4:
                        Console.WriteLine("Area of Square:" + (num1 * num2));
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Do you want to continue");
                ch = Console.ReadLine()[0];
                while (ch == 'y' || ch == 'Y') ;







            }
    }
}
}

