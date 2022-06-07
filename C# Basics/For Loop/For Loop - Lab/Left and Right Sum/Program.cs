using System;

namespace LeftandRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int upSideSum = 0;
            int downSideSum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                upSideSum = upSideSum + num;
            }
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                downSideSum = downSideSum + num;
            }
            if (upSideSum == downSideSum)
            {
                Console.WriteLine($"Yes, sum = {upSideSum}");
            }
            else
            {
                int diff = upSideSum - downSideSum;
                diff = Math.Abs(diff);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
