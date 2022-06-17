using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.looping.pattern_pgm
{
    class wap_print
    {
          /*   1
    2 2 2 
    3 3 3 3 
    4 4 4 4 */
    
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine(j + " ");
                }
                Console.WriteLine();
            }

        }

    }
}
class wap_print
{
    /*  *  * * * *
      * * * * 
      * * *
      * *
       *    */
    static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 5; j >= i; j--)
            {
                Console.WriteLine("*");
            }
        }
        Console.WriteLine();
    }
}





class wap
/*1 2 3 4 5 
1 2 3 4 
1 2 3 
1 2 */
{ 

    static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 5; j >= i;)
            {
                Console.WriteLine(j + " ");

            }
        }
    }
}



    

