using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (max < num)
                {
                    max = num;
                }

            }
            int sumMinusMaxN = sum - max;
            if (sumMinusMaxN == max)
            {
                Console.WriteLine($"Yes\nSum = {max}");
            }
            else
            {

                int diff = max - sumMinusMaxN;
                diff = Math.Abs(diff);
                Console.WriteLine($"No\nDiff = {diff}");
            }

        }
    }
}
