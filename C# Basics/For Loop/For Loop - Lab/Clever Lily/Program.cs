using System;

namespace lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            double washMachinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            double totalToys = 0;
            double totalMoney = 0;

            double savedMoney = 0;
            double profit = 0;

            double moneyLeft = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    totalMoney += 10;
                    savedMoney += totalMoney;
                    savedMoney -= 1;
                }
                else
                {
                    totalToys++;
                }

            }
            profit = savedMoney + (totalToys * toysPrice);
            moneyLeft = profit - washMachinePrice;

            if (profit >= washMachinePrice)
            {
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else
            {
                moneyLeft = Math.Abs(moneyLeft);
                Console.WriteLine($"No! {moneyLeft:f2}");
            }
        }
    }
}
