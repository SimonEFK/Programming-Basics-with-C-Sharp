using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int row = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine()) * row;
            double profit = 0;

            switch (type)
            {
                case "premiere":
                    profit = capacity * 12.00;
                    break;
                case "normal":
                    profit = capacity * 7.50;
                    break;
                case "discount":
                    profit = capacity * 5.00;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{profit:f2}");

        }

    }
}
