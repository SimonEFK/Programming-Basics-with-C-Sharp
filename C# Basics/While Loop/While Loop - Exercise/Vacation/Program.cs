using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayCost = double.Parse(Console.ReadLine());
            double startMoney = double.Parse(Console.ReadLine());

            
            int spendCounter = 0;
            int dayCounter = 0;
            double moneySaved = 0;
            double moneyToSpendOrSave = 0;

            while (startMoney < holidayCost && spendCounter < 5)
            {
                string spendOrNah = Console.ReadLine();
                moneyToSpendOrSave = double.Parse(Console.ReadLine());
                dayCounter++;
                
                if (spendOrNah=="save")
                {
                    spendCounter = 0;
                    startMoney += moneyToSpendOrSave;
                    
                   
                }
                else if (spendOrNah == "spend")
                {
                    spendCounter++;
                    if (moneyToSpendOrSave > startMoney)
                    {
                        startMoney = 0;


                    }
                    else
                    {
                        startMoney = startMoney-moneyToSpendOrSave;
                         
                    }


                }
            }
            if (spendCounter==5)
            {
                Console.WriteLine($"You can't save the money.\n{dayCounter}");
            }
            else
            {
                Console.WriteLine($"You saved the money for {dayCounter} days.");
            }
        }
    }
}
