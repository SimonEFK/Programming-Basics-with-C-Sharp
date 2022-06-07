using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int storage = 0;

            for (int i = 1; i <= n; i++)
            {
                int nextnum = int.Parse(Console.ReadLine());
                storage += nextnum;
            }
            Console.WriteLine(storage);

        }
    }
}
