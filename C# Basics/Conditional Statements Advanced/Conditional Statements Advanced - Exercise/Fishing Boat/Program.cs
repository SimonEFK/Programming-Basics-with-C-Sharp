using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            var fisherman = int.Parse(Console.ReadLine());
            var boatPrice = 0.0;
            var total = 0.0;
            var discount = 0.0;
            var evenDiscount = 0.0;


            switch (season)
            {
                case "spring":
                    if (fisherman > 0 && fisherman <= 6)
                    {
                        boatPrice = 3000;
                        discount = 3000 * 0.10;
                        total = boatPrice - discount;
                        if (fisherman % 2 == 0)
                        {
                            evenDiscount = total * 0.05;
                            total -= evenDiscount;
                        }
                    }
                    else if (fisherman >= 7 && fisherman <= 11)
                    {
                        boatPrice = 3000;
                        discount = 3000 * 0.15;
                        total = boatPrice - discount;
                        if (fisherman % 2 == 0)
                        {
                            evenDiscount = total * 0.05;
                            total -= evenDiscount;
                        }
                    }
                    else if (fisherman >= 12)
                    {
                        boatPrice = 3000;
                        discount = 3000 * 0.25;
                        total = boatPrice - discount;
                        if (fisherman % 2 == 0)
                        {
                            evenDiscount = total * 0.05;
                            total -= evenDiscount;
                        }
                    }
                    break;
                case "summer":
                    if (fisherman > 0 && fisherman <= 6)
                    {
                        boatPrice = 4200;
                        discount = 4200 * 0.10;
                        total = boatPrice - discount;
                        if (fisherman % 2 == 0)
                        {
                            evenDiscount = total * 0.05;
                            total -= evenDiscount;
                        }
                    }
                    else if (fisherman >= 7 && fisherman <= 11)
                    {
                        boatPrice = 4200;
                        discount = 4200 * 0.15;
                        total = boatPrice - discount;
                        if (fisherman % 2 == 0)
                        {
                            evenDiscount = total * 0.05;
                            total -= evenDiscount;
                        }
                    }
                    else if (fisherman >= 12)
                    {
                        boatPrice = 4200;
                        discount = 4200 * 0.25;
                        total = boatPrice - discount;
                        if (fisherman % 2 == 0)
                        {
                            evenDiscount = total * 0.05;
                            total -= evenDiscount;
                        }
                    }
                    break;
                case "winter":
                    if (fisherman > 0 && fisherman <= 6)
                    {
                        boatPrice = 2600;
                        discount = 2600 * 0.10;
                        total = boatPrice - discount;
                        if (fisherman % 2 == 0)
                        {
                            evenDiscount = total * 0.05;
                            total -= evenDiscount;
                        }
                    }
                    else if (fisherman >= 7 && fisherman <= 11)
                    {
                        boatPrice = 2600;
                        discount = 2600 * 0.15;
                        total = boatPrice - discount;
                        if (fisherman % 2 == 0)
                        {
                            evenDiscount = total * 0.05;
                            total -= evenDiscount;
                        }
                    }
                    else if (fisherman >= 12)
                    {
                        boatPrice = 2600;
                        discount = 2600 * 0.25;
                        total = boatPrice - discount;
                        if (fisherman % 2 == 0)
                        {
                            evenDiscount = total * 0.05;
                            total -= evenDiscount;
                        }
                    }
                    break;
                case "autumn":
                    if (fisherman > 0 && fisherman <= 6)
                    {
                        boatPrice = 4200;
                        discount = 4200 * 0.10;
                        total = boatPrice - discount;
                        //if (fisherman % 2 == 0)
                        //{
                        //    evenDiscount = total * 0.05;
                        //    total -= evenDiscount;
                        //}
                    }
                    else if (fisherman >= 7 && fisherman <= 11)
                    {
                        boatPrice = 4200;
                        discount = 4200 * 0.15;
                        total = boatPrice - discount;
                        //if (fisherman % 2 == 0)
                        //{
                        //    evenDiscount = total * 0.05;
                        //    total -= evenDiscount;
                        //}
                    }
                    else if (fisherman >= 12)
                    {
                        boatPrice = 4200;
                        discount = 4200 * 0.25;
                        total = boatPrice - discount;
                        //if (fisherman % 2 == 0)
                        //{
                        //    evenDiscount = total * 0.05;
                        //    total -= evenDiscount;
                        //}
                    }
                    break;
                default:
                    break;
            }

            double moneyLeft = budget - total;
            double moneyNeeded = total - budget;

            if (budget >= total)
            {
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else if (budget < total)
            {
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }






        }
    }
}
