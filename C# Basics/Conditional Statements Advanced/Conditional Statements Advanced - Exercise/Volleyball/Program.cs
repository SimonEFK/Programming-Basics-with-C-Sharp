using System;

namespace Volllleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string leapOrNah = Console.ReadLine().ToLower();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double daysInSofia = 48 - h;
            double playingVoleyB = daysInSofia * 3 / 4;
            double holidays = p * 2 / 3;
            double total = playingVoleyB + holidays + h;

            switch (leapOrNah)
            {
                case "leap":
                    total *= 1.15;
                    Console.WriteLine($"{Math.Floor(total)}");
                    break;
                default:
                    Console.WriteLine($"{Math.Floor(total)}");
                    break;
            }





        }
    }
}
