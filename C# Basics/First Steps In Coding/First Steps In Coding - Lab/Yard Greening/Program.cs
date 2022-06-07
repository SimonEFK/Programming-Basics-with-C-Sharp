using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMetersOfTheYard = double.Parse(Console.ReadLine());
            double priceForSquareMeter = 7.61;
            double priceForTheWork = squareMetersOfTheYard * priceForSquareMeter;
            double discountOf18Percent = priceForTheWork * 0.18;
            double priceWithDiscount = priceForTheWork - discountOf18Percent;
            Console.WriteLine($"The final price is: {priceWithDiscount} lv.");
            Console.WriteLine($"The Discount is: {discountOf18Percent} lv.");

        }
    }
}
