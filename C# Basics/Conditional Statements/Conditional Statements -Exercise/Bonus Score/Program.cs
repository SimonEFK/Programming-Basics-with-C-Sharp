using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonusPoints = 0.0;
            if (number <= 100)
            {
                bonusPoints = 5;

            }
            else if (number > 100 && (number <= 999))
            {
                bonusPoints = number * 0.20;
            }
            else if (number >= 1000 && (number < 9999))
            {
                bonusPoints = number * 0.10;
            }

            if (number % 2 == 0)
            {
                bonusPoints += 1;
            }
            else if (number % 10 == 5)
            {
                bonusPoints += 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(number + bonusPoints);
        }
    }
}
