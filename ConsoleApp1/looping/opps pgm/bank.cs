using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.opps_pgm
{
    class bank
    {
        int accno;
        string acctype;
        string custname;
        int balance;

        public void input()
        {
            Console.WriteLine("Enter account number");
            accno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter account type");
            acctype = Console.ReadLine();
            Console.WriteLine("Enter customer name");
            custname = Console.ReadLine();
            balance = int.Parse(Console.ReadLine());

        }
        public void show()
        {
            Console.WriteLine();
            Console.WriteLine("Account number"+accno);
            Console.WriteLine("Account type" + acctype);
             Console.WriteLine("customer name" + custname);
                Console.WriteLine("Balance" +balance);

        }
        public void withdraw()
        {
            Console.WriteLine("Enter amount you can withdraw");
            int w = int.Parse(Console.ReadLine());
            balance = balance - w;
            display();


        }
        public void deposit()
        {
            Console.WriteLine("Enter amount you can deposit");
            int d = int.Parse(Console.ReadLine());
            balance = balance + d;
            display();


        }
        public void display()
        {
            Console.WriteLine("The updated available balance is " +balance);
        }
        static void Main(string[] args)
        {
            bank b = new bank();
            b.input();
            b.show();
            Console.WriteLine("which operation you can perform w or d");
            int op = char.Parse(Console.ReadLine());
            if (op == 'w')
                b.withdraw();
            else if (op == 'd')
                b.deposit();
            else
                Console.WriteLine("you enter wrong choice");

        }


    }
}
