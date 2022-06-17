using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.opps_pgm
{
    class Arithmatic_Hw
    {
        int x;
        int y;
         void Calculate()
        {
            Console.WriteLine("Addition=" + (6 + 7));
        }
        void Calculate(int a, int b)
        {
            Console.WriteLine("Substraction=" + (a - b));
        }

             void Calculate(int x, int y, float z)
            {
                Console.WriteLine("Multiplication=" + (x * y * z));

            }
             void Calculate(float a, float b)

            {
                Console.WriteLine("Division=" + (a / b));
            }
            static void Main(string[] args)
            {
                Arithmatic_Hw s = new Arithmatic_Hw();
                s.Calculate();
                s.Calculate(20, 10);
                s.Calculate(2,6,2.5f);
                s.Calculate(10.0f,2.5f);
            }









        }

    }

