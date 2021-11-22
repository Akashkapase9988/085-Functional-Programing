using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programing_085
{
    public class Flip_Coin
    {
        public static void Flip()
        {

            int Flipcount =Convert.ToInt32( Console.ReadLine());
            int Head_count = 0;
            int Tail_count = 0;
            for (int i = 0; i <= Flipcount; i++)
            {
                Random random = new Random();
                int choice = random.Next(1, 3);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("HEAD ");
                        Head_count++;
                        break;
                    case 2:
                        Console.WriteLine("TAIL");
                        Tail_count++;
                        break;
                }
            }
            Console.WriteLine("Coin was filped " + "  " + Flipcount + "  " + "time");
            //double Head_percentage = (Head_count / Flipcount) * 100;
            //double Tail_percentage = (Tail_count / Flipcount) * 100;
            Console.WriteLine("Head coming " + "  " + Head_count + "  " + "times and percentage of head comming is " + "  " + (Head_count / Flipcount) * 100 + "  " + "percent");
            Console.WriteLine("Tail coming " + "  " + Tail_count + "  " + "times and percentage of Tail comming is " + "  " + (Tail_count / Flipcount) * 100 + "  " + "percent");
        }
    }
}
