using System;

namespace Sequance2k_1While
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int formula = 1;
            int sum = 0;

            while (formula<=num)
            {
                Console.WriteLine($"{formula}");
                formula=formula * 2 + 1;

            }
        }
    }
}
