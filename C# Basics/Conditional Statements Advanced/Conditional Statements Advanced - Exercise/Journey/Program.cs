using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            double moneyLeft = 0;
            double cost = 0;


            switch (season)
            {
                case "summer":
                    if (budget > 0 && budget <= 100)
                    {
                        cost = budget * 0.30;
                        moneyLeft = budget - cost;
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine($"Camp - {cost:f2}");
                    }
                    else if (budget > 100 && budget <= 1000)
                    {
                        cost = budget * 0.40;
                        moneyLeft = budget - cost;
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine($"Camp - {cost:f2}");
                    }
                    else if (budget > 1000)
                    {
                        cost = budget * 0.90;
                        moneyLeft = budget - cost;
                        Console.WriteLine("Somewhere in Europe");
                        Console.WriteLine($"Hotel - {cost:f2}");
                    }
                    break;
                case "winter":
                    if (budget > 0 && budget <= 100)
                    {
                        cost = budget * 0.70;
                        moneyLeft = budget - cost;
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine($"Hotel - {cost:f2}");
                    }
                    else if (budget > 100 && budget <= 1000)
                    {
                        cost = budget * 0.80;
                        moneyLeft = budget - cost;
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine($"Hotel - {cost:f2}");
                    }
                    else if (budget > 1000)
                    {
                        cost = budget * 0.90;
                        moneyLeft = budget - cost;
                        Console.WriteLine("Somewhere in Europe");
                        Console.WriteLine($"Hotel - {cost:f2}");
                    }
                    break;
                default:
                    break;
            }


        }
    }
}
