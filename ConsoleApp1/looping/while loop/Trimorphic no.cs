using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.while_loop
{
    class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            long cube;
            bool flag = false;
            int temp = num;
            cube = num * num * num;
            while (temp > 0)
            {
                if (temp%10==cube%10)
                {
                    flag = true;
                    temp = temp / 10;
                    cube = cube / 10;

                }
                else
                {
                    flag = false;
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine("Trimorphic");
            }
            else
            {
                Console.WriteLine("Not Trimorphic");
            }
           

        }
    }
}
