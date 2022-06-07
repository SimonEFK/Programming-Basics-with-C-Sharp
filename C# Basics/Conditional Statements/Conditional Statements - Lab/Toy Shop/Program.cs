using System;

namespace _06AreofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            double amountPuzzle = double.Parse(Console.ReadLine());
            double amountDolls = double.Parse(Console.ReadLine());
            double amountBears = double.Parse(Console.ReadLine());
            double amountMinnions = double.Parse(Console.ReadLine());
            double amountTrucks = double.Parse(Console.ReadLine());

            double pricePuzzle = 2.60;
            double priceDolls = 3;
            double priceBears = 4.10;
            double priceMinnions = 8.20;
            double priceTrucks = 2;
            double totalToysPrice = amountPuzzle * pricePuzzle + amountDolls * priceDolls + amountBears * priceBears + amountMinnions * priceMinnions + amountTrucks * priceTrucks;
            double totalToysAmount = amountPuzzle + amountDolls + amountBears + amountMinnions + amountTrucks;
            double discount = totalToysPrice * 0.25;
            if (totalToysAmount >= 50)
            {
                totalToysPrice -= discount;
            }
            else
            {
                totalToysPrice = totalToysPrice;
            }
            double rent = totalToysPrice * 0.10;
            double profit = totalToysPrice - rent;
            double moneyLeft = profit - holidayPrice;
            double moneyNeeded = holidayPrice - profit;
            if (profit >= holidayPrice)
            {
                Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
            }



        }
    }
}
