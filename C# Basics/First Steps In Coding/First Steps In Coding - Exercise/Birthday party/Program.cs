using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double rentOfTheHall = double.Parse(Console.ReadLine());
            double priceForTheHall = rentOfTheHall;
            double cakePrice = priceForTheHall / 100 * 20;
            double priceDrinks = cakePrice - cakePrice / 100 * 45;
            double animatorPrice = priceForTheHall / 3;
            double totalPrice = priceForTheHall + cakePrice + priceDrinks + animatorPrice;
            Console.WriteLine(totalPrice);


        }
    }
}
