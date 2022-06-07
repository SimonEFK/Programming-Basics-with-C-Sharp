using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {

            double sum = 0;
            double totalSum = 0;
            while (true)
            {
                string input = Console.ReadLine();//.ToLower();
                if (input == "NoMoreMoney")
                {
                    break;
                }
                sum = double.Parse(input);
                if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                totalSum += sum;
                Console.WriteLine($"Increase: {sum:f2}");
            }
            Console.WriteLine($"Total: {totalSum:f2}");
        }
    }
}
