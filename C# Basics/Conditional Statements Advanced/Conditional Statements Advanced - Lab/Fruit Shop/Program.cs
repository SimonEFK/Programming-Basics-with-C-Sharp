using System;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            bool wDays = (day == "Saturday" || day == "Sunday");
            bool workDays = (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday");
            double bananaP = 0;
            double appleP = 0;
            double orangeP = 0;
            double grapefruitP = 0;
            double kiwiP = 0;
            double pineappleP = 0;
            double grapesP = 0;
            double totalPrice = 0;


            if (workDays)
            {
                bananaP = 2.50;
                appleP = 1.20;
                orangeP = 0.85;
                grapefruitP = 1.45;
                kiwiP = 2.70;
                pineappleP = 5.50;
                grapesP = 3.85;

            }
            else if (wDays)
            {
                bananaP = 2.70;
                appleP = 1.25;
                orangeP = 0.90;
                grapefruitP = 1.60;
                kiwiP = 3.00;
                pineappleP = 5.60;
                grapesP = 4.20;
            }
            //else
            //{
            //    Console.WriteLine("error");
            //}
            switch (product)
            {
                case "banana":
                    totalPrice = bananaP * amount;
                    break;
                case "apple":
                    totalPrice = appleP * amount;
                    break;
                case "orange":
                    totalPrice = orangeP * amount;
                    break;
                case "grapefruit":
                    totalPrice = grapefruitP * amount;
                    break;
                case "kiwi":
                    totalPrice = kiwiP * amount;
                    break;
                case "pineapple":
                    totalPrice = pineappleP * amount;
                    break;
                case "grapes":
                    totalPrice = grapesP * amount;
                    break;
                default:
                    //Console.WriteLine("error");
                    break;
            }
            if (totalPrice == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{totalPrice:f2}");
            }

        }

    }
}
