using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()) - 1;
            string type = Console.ReadLine().ToLower();
            string positiveOrNah = Console.ReadLine().ToLower();
            double cost = 0;

            switch (type)
            {
                case "room for one person":
                    cost = days * 18.00;
                    break;
                case "apartment":
                    cost = days * 25.00;
                    if (days < 10)
                    {
                        cost -= (cost * 0.30);
                    }
                    else if (days >= 10 &&days<= 15)
                    {
                        cost -= (cost * 0.35);
                    }
                    else if (days > 15)
                    {
                        cost -= (cost * 0.50);
                    }
                    break;
                case "president apartment":
                    cost = days * 35.00;
                    if (days < 10)
                    {
                        cost -= (cost * 0.10);
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        cost -= (cost * 0.15);
                    }
                    else if (days > 15)
                    {
                        cost -= (cost * 0.20);
                    }
                    break;
                default:
                    break;
            }
            switch (positiveOrNah)
            {
                case "positive":
                    cost += (cost * 0.25);
                    break;
                case "negative":
                    cost -= (cost * 0.10);
                    break;
                default:
                    break;
         
            }

            Console.WriteLine($"{cost:f2}");
        }
    }
}
