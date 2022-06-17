using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.assesment_test_3
{
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
         





            
        
    
    
}


            
      
    
        
