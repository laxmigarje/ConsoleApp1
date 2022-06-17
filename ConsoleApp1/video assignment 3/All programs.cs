using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.video_assignment_3
{
    class Class1
    {

        class Class8
        {
            static void Main(string[] args)
            {
                for (int i = 121; i <= 229; i++)
                    if (i % 2 == 0)
                        Console.WriteLine("even number" + i);

            }
        }
    }

}


class odd_no
{
    static void Main(string[] args)
    {
        for (int i = 521; i >=229; i--)
            if (i % 2 != 0)
                Console.WriteLine("odd number is:" + i);
    }
}



class Class8
{
    static void Main(string[] args)
    {
        for(char alphabet = 'a'; alphabet<='z'; alphabet++)
            Console.WriteLine(alphabet);
    }
}



class Class9
{
    static void Main(string[] args)
    {
        int i, num, sum = 0;
        Console.WriteLine("Enter a number");
        num = Convert.ToInt32(Console.ReadLine());
        for (i = 2; i <= num; i++)
            if (i % 2 == 0)
                sum = i;
        Console.WriteLine("Total sum of all even numbers less than  "+num+" : "+sum);
    }
}

class Class10
{
    static void Main(string[] args)
    {
        int i, num, sum = 0;
        Console.WriteLine("Enter a number");
        num = Convert.ToInt32(Console.ReadLine());
        for (i = 1; i <= num; i++)
            if (i % 2 != 0)
                sum = i;
        Console.WriteLine("Total sum of all odd numbers less than  " + num + " : " + sum);
    }

}



class Count_no_digits
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        int num = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while (num > 0)
        {
            int rem = num % 10;
            count++;
            num = num / 10;

        }
        Console.WriteLine("Number is" + count + " Digit");

    }
}


class Prime_no
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Start Number: ");
            int startNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the End Number : ");
            int endNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Prime Numbers between 400 and 300 are : ");
            for (int i = 400; i <= 300; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
        }
    }
}





class Product
{
    static void Main(string[] args)
    {

        int num, product = 1;

        
        Console.Write("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());

        
        while (num != 0)
        {
            product = product * (num % 10);

           
            num = num / 10;
        }

        Console.WriteLine("Product of digits = " + product);

        Console.ReadLine();
    }
}



class Frequency
{
 static int frequencyDigits(int n,
                               int d)
    {
        
     
        int c = 0;

      
      
        while (n > 0)
        {

            
            if (n % 10 == d)
                c++;
            
            n = n / 10;
        }
        return c;
    }
 static public void Main(String[] args)
    {

        
        int N = 1122322;

        
        int D = 2;

        Console.WriteLine(frequencyDigits(N, D));

    }
}


class Table
{ 


static void Main(string[] args)
{

    int i, num;

    
    Console.WriteLine("Enter number to print table: ");
    num = Convert.ToInt32(Console.ReadLine());

    for (i = 1; i <= 10; i++)
    {
                  
        Console.Write("{0} X {1} = {2} \n", num, i, num * i);
    }
    Console.ReadLine();
}
}


class Squares
{
    static void Main(string[] args)
    {
        int i, num , sqr;
        Console.WriteLine("enter the number");
         num = int.Parse(Console.ReadLine());

        for(i=1; i<=20;i++)
        {
            sqr = num * num;


        }
        Console.WriteLine("sqr");
    }
}


class Power
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the base");
        int bas = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the power");
        int pow = int.Parse(Console.ReadLine());
        int count = 1;
        for (int i = 1; i <= pow; i++)
        {
            count = count * bas
;
        }
        Console.WriteLine("result is " + count);
    }
}



class factorial
{
    static void Main(string[] args)
    {
        int sum = 0;
        for (int i = 1; i <= 5; i++)
        {
            int fact = 1;
            for (int j = 1; j <= i; j++)
            {
                fact = fact * j;
            }
            sum = sum + fact;

        }
        Console.WriteLine(sum);
    }
}



class Krishmurthy
{


    static int factorial(int n)
    {
        int fact = 1;

        while (n != 0)
        {
            fact = fact * n;
            n--;
        }

        return fact;
    }



    static bool isKrishnamurthy(int n)
    {
        int sum = 0;

        int temp = n;
        while (temp != 0)
        {




            sum += factorial(temp % 10);



            temp = temp / 10;
        }



        return (sum == n);
    }


    public static void Main()
    {
        int n = 145;
        if (isKrishnamurthy(n))
            Console.Write("YES");
        else
            Console.Write("NO");
    }

}


class Class11
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        int num = Convert.ToInt32(Console.ReadLine());
        int reverse = 0, temp;
        temp = num;
        while (temp > 0)
        {
            int rem = temp % 10;
            reverse = (reverse * 10) + rem;
            temp = temp / 10;

        }
        if (num == reverse)
        {
            Console.WriteLine("Number is palindrome");
        }
        else
        {
            Console.WriteLine("Number is not palindrome");
        }
    }
}


class HarshadNo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        int num = Convert.ToInt32(Console.ReadLine());
        int temp = 0, sum = 0;
        temp = num;
        while (temp > 0)
        {
            int rem = temp % 10;
            sum = sum + rem;
            temp = temp / 10;

        }
        if (num % sum == 0)
        {
            Console.WriteLine("Harshad Number");
        }
        else
        {
            Console.WriteLine("Non Harshad Number");
        }
    }
}




class Automorhic
{
    public class AutomorphicProgram
    {
        public static void Main()
        {
            Console.Write("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (CheckAutomorphicNumber(number))
            {
                Console.WriteLine("Automorphic Number");
            }
            else
            {
                Console.WriteLine("Not Automorphic Number");
            }

            Console.ReadLine();
        }

        public static bool CheckAutomorphicNumber(int no)
        {
            int square = no * no;
            while (no > 0)
            {
                if (no % 10 != square % 10)
                {
                    return false;
                }
                no = no / 10;
                square = square / 10;
            }
            return true;
        }
    }
}


   