using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nStart = int.Parse(Console.ReadLine());
            int nEnd = int.Parse(Console.ReadLine());
            int magicNumb = int.Parse(Console.ReadLine());
            int sum = 0;
            int totalCombindation = 0;
            int combinations = 0;

            for (int i = nStart; i <= nEnd; i++)
            {
                for (int j = nStart; j <= nEnd; j++)
                {
                    combinations++;
                    sum = i + j;
                    if (magicNumb == sum)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {i + j})");
                        goto LoopEnd;
                    }
                }
            }
            Console.WriteLine($"{combinations} combinations - neither equals {magicNumb}");
            LoopEnd:
            {
                return;
            }
        }
    }
}
