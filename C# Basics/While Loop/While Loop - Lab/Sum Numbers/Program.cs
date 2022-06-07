using System;

namespace SumNumbersWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number = int.Parse(Console.ReadLine());

            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (sum>=number)
                {
                    break;
                }

            }
            Console.WriteLine($"{sum}");

        }
    }
}
