using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int campainDuration = int.Parse(Console.ReadLine());
            int numOfBakers = int.Parse(Console.ReadLine());
            int numOfCakes = int.Parse(Console.ReadLine());
            int numOfWaffles = int.Parse(Console.ReadLine());
            int numOfPancakes = int.Parse(Console.ReadLine());
            double cakePrice = 45;
            double wafflePrice = 5.80;
            double pancakesPrice = 3.20;
            double oneBakerWorkPerOneDay = numOfCakes * cakePrice + numOfWaffles * wafflePrice + numOfPancakes * pancakesPrice;
            double totalSumForOneDay = oneBakerWorkPerOneDay * numOfBakers;
            double wholeCampainProfit = totalSumForOneDay * campainDuration;
            double profit = wholeCampainProfit - (wholeCampainProfit / 8);
            Console.WriteLine(profit);
        }
    }
}
