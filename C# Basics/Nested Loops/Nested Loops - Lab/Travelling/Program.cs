using System;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = string.Empty;
            bool isDestinationEnd = false;
            loopStart:
            while (isDestinationEnd == false)

            {
                destination = Console.ReadLine();
                if (destination=="End")
                {
                    isDestinationEnd = true;
                    goto loopStart;
                }
                double target = double.Parse(Console.ReadLine());
                double moneyNeeded = 0;
                while (true)
                {
                    double money = double.Parse(Console.ReadLine());
                    moneyNeeded += money;
                    if (moneyNeeded >= target)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }
            }
            return;
            
        }
    }
}
