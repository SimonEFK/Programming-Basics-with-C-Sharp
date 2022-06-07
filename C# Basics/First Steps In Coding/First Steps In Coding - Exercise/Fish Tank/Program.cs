using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenth = int.Parse(Console.ReadLine());
            int wenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentageThrash = double.Parse(Console.ReadLine());

            double FishTankVolume = lenth * wenght * height;
            double amountOfWateFishTankCanTake = FishTankVolume * 0.001;
            double percent = percentageThrash * 0.01;
            double total = amountOfWateFishTankCanTake * (1 - percent);

            Console.WriteLine(total);

        }
    }
}
