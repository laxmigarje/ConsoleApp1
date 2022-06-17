using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.assessment_test_1
{
    class Class7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter fist no");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second no");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation which you wants to perform");
            Console.WriteLine("+=addition\n  -=substraction\n  *=multiplation\n  /=division");
            string choice = Console.ReadLine();

            switch (choice)

            {
                case "+":
                    Console.WriteLine("addition is =" + (n1 + n2));
                    break;
                case "-":
                    Console.WriteLine("substraction is =" + (n1 - n2));
                    break;
                case "*":
                    Console.WriteLine("multiplication is =" + (n1 * n2));
                    break;

                case "/":
                    Console.WriteLine("Division is =" + (n1 / n2));
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;


            }



            }
        }
    }
