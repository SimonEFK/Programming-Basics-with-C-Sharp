using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double cents = change * 100;
            int totalCents = (int) cents;
            int cointCOunter = 0;

            

            while (totalCents>0)
            {
                if (totalCents-200>=0)
                {
                    totalCents -= 200;
                    cointCOunter++;
                }
                else if (totalCents-100>=0)
                {
                    totalCents -= 100;
                    cointCOunter++;
                }
                else if (totalCents - 50 >= 0)
                {
                    totalCents -= 50;
                    cointCOunter++;
                }
                else if (totalCents - 20 >= 0)
                {
                    totalCents -= 20;
                    cointCOunter++;
                }
                else if (totalCents - 10 >= 0)
                {
                    totalCents -= 10;
                    cointCOunter++;
                }
                else if (totalCents - 5 >= 0)
                {
                    totalCents -= 5;
                    cointCOunter++;
                }
                else if (totalCents - 2 >= 0)
                {
                    totalCents -= 2;
                    cointCOunter++;
                }
                else if (totalCents - 1 >= 0)
                {
                    totalCents -= 1;
                    cointCOunter++;
                }
            }
            Console.WriteLine($"{cointCOunter}");
        }
    }
}
