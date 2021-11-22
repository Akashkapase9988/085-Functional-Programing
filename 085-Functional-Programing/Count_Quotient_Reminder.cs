using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programing_085
{
    class Count_Quotient_Reminder
    {
        public static void solution()
        {
            int dividend, divisor;
            Console.Write("Enter a number as dividend: ");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number as divisor: ");
            divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend = " + dividend + " Divisor = " + divisor);
            Console.WriteLine("The quotient is: " + quotient);
            Console.WriteLine("The remainder is: " + remainder);
        }
    }
}
