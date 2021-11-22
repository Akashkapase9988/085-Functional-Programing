using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programing_085
{
    class Powerof2
    {
        public static void PrintPower()
        {
            int n;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            if (0 <= n && n < 31)
            {
                Console.WriteLine("The power's of 2 are:");
                for (int i = 0; i <= n; i++)
                {
                    Console.Write("");
                    Console.WriteLine(+(2 << i));
                }
            }
            else
            {
                Console.WriteLine("Integer can't take the power of 2 as bigger than 31, Enter smaller");
            }
        }
    }
}
