using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForStrewBerries = double.Parse(Console.ReadLine());
            double bannanasAmount = double.Parse(Console.ReadLine());
            double orangesAmount = double.Parse(Console.ReadLine());
            double raspberriesAmount = double.Parse(Console.ReadLine());
            double strewberriesAmount = double.Parse(Console.ReadLine());

            double strawberriesPrice = priceForStrewBerries;
            double raspberriesPrice = strawberriesPrice / 2;
            double orangesPrice = raspberriesPrice - 0.4 * raspberriesPrice;
            double bannanaPrice = raspberriesPrice - 0.8 * raspberriesPrice;

            double totalPriceForRasberries = raspberriesAmount * raspberriesPrice;
            double totalPriceForOranges = orangesAmount * orangesPrice;
            double totalPriceForBannanas = bannanasAmount * bannanaPrice;
            double totalPriceForStrawberries = priceForStrewBerries * strewberriesAmount;

            double totalPrice = totalPriceForRasberries + totalPriceForOranges + totalPriceForBannanas + totalPriceForStrawberries;
            Console.WriteLine($"{totalPrice:F2}");

        }
    }
}
