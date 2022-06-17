using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.video_assignment_1
{
    class Class1
    {
        class Leap_year
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a year");
                int year = int.Parse(Console.ReadLine());
                if (year % 4 == 0)
                {
                    Console.WriteLine("leap year");
                }
                else
                {
                    Console.WriteLine("Not leap year");
                }
            }
        }
    }

}








class Class2
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the number");
        int n = int.Parse(Console.ReadLine());
        if (n % 5 == 0 && n % 11 == 0)
        {
            Console.WriteLine("number is divisible by 5 and 11");
        }
        else
        {
            Console.WriteLine("number is not divisible by 5 and 11");
        }
    }

}



class Class3
{
    static void Main(string[] args)
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());
        int max = 0;

        if (num1 > num2 && num1 > num3)
        {
            max = num1;
        }
        else if (num2 > num1 && num2 > num3)
        {
            max = num2;
        }
        else
        {
            max = num3;


        }
    }
}



class Class4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter any character");
        char ch = char.Parse(Console.ReadLine());
        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            Console.WriteLine(ch + "is an vowel");
        else
            Console.WriteLine(ch + "consonant");

    }
}





class Class5
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



class _ve__ve_or_zero
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Enter a number");
        n = int.Parse(Console.ReadLine());
        if (n == 0)
        {
            Console.WriteLine(n + "is zero");
        }
        else if (n > 0)
        {
            Console.WriteLine(n + "n is positive number");
        }
        else
        {
            Console.WriteLine(n + "n is a negative number");
        }
    }
}



class Class6
{
    static void Main(string[] args)
    {
        char ch;
        Console.WriteLine("Enter any character:");
        ch = char.Parse(Console.ReadLine());
        if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
        {
            Console.WriteLine(ch + "is an Alphabet");
        }
        else if (ch >= '0' && ch <= '9')
        {
            Console.WriteLine(ch + "is a Digit");
        }
        else
        {
            Console.WriteLine(ch + "is a special character");
        }
    }
}




class even_odd_no
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("Even number");
        }
        else
        {
            Console.WriteLine("Odd number");
        }
    }
}


/*switch case*/
class simple_calculater
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



class days
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter The Character");
        char ch = char.Parse(Console.ReadLine());

        switch (ch)
        {
            case '1':
                Console.WriteLine("monday");
                break;

            case '2':
                Console.WriteLine("tuesday");
                break;

            case '3':
                Console.WriteLine("wendsday");
                break;

            case '4':
                Console.WriteLine("thursday");
                break;

            case '5':
                Console.WriteLine("fraiday");
                break;

            case '6':
                Console.WriteLine("saturday");
                break;


            default:
                Console.WriteLine("sunday");
                break;


        }
    }
}




class Class7
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



