using System;

namespace GodzilavsmfukinKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double projectBudget = double.Parse(Console.ReadLine());
            double extrasNum = double.Parse(Console.ReadLine());
            double oneExtraCostumeCost = double.Parse(Console.ReadLine());
            double totamCostForCostumes = extrasNum * oneExtraCostumeCost;
            double decor = projectBudget * 0.10;
            double costumeDioscount = 0;
            if (extrasNum >= 150)
            {
                costumeDioscount = totamCostForCostumes * 0.10;
                totamCostForCostumes -= costumeDioscount;
            }

            double projectCost = decor + totamCostForCostumes;
            double moneyLeft = projectBudget - projectCost;
            double moneyNeeded = projectCost - projectBudget;
            if (projectBudget >= decor && projectBudget >= projectCost)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");

            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }


        }
    }
}
