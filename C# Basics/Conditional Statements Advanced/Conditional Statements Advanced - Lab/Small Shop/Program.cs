using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string city = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (product == "coffee")
            {
                if (city == "sofia") { price = 0.5; }
                else if (city == "plovdiv") { price = 0.4; }
                else if (city == "varna") { price = 0.45; }

            }
            else if (product == "water")
            {
                if (city == "sofia") { price = 0.80; }
                else if (city == "plovdiv") { price = 0.70; }
                else if (city == "varna") { price = 0.70; }
            }
            else if (product == "beer")
            {
                if (city == "sofia") { price = 1.20; }
                else if (city == "plovdiv") { price = 1.15; }
                else if (city == "varna") { price = 1.10; }
            }
            else if (product == "sweets")
            {
                if (city == "sofia") { price = 1.45; }
                else if (city == "plovdiv") { price = 1.30; }
                else if (city == "varna") { price = 1.35; }
            }
            else if (product == "peanuts")
            {
                if (city == "sofia") { price = 1.60; }
                else if (city == "plovdiv") { price = 1.50; }
                else if (city == "varna") { price = 1.55; }
            }
            double totalPrice = price * quantity;
            Console.WriteLine($"{totalPrice}");
        }
    }
}