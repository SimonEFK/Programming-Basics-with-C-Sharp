using System;

namespace NewHourse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowersType = (Console.ReadLine());//.ToLower());
            double floNum = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double rosesPrice = 5.0;
            double dahliasPrice = 3.80;
            double tulipsPrice = 2.80;
            double narcissusPrice = 3.0;
            double galdiolusPrice = 2.50;
            double total = 0.0;
            double discount = 0.0;

            switch (flowersType)
            {
                case "Roses":
                    total = rosesPrice * floNum;
                    if (floNum > 80)
                    {
                        discount = total * 0.10;
                        total -= discount;
                    }
                    break;
                case "Dahlias":
                    total = dahliasPrice * floNum;
                    if (floNum > 90)
                    {
                        discount = total * 0.15;
                        total -= discount;
                    }
                    break;
                case "Tulips":
                    total = tulipsPrice * floNum;
                    if (floNum > 80)
                    {
                        discount = total * 0.15;
                        total -= discount;
                    }
                    break;
                case "Narcissus":
                    total = narcissusPrice * floNum;
                    if (floNum < 120)
                    {
                        discount = total * 0.15;
                        total += discount;
                    }
                    break;
                case "Gladiolus":
                    total = galdiolusPrice * floNum;
                    if (floNum < 80)
                    {
                        discount = total * 0.20;
                        total += discount;
                    }                   
                    break;
                default:
                    break;
            }
            double moneyLeft = budget - total;
            moneyLeft = Math.Abs(moneyLeft);
            if (budget>=total)
            {
                Console.WriteLine($"Hey, you have a great garden with {floNum} {flowersType} and {moneyLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {moneyLeft:f2} leva more.");
            }
        }
    }
}