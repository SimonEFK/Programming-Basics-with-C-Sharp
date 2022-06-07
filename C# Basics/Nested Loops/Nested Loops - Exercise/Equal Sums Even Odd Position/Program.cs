using System;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            int position = 0;

            for (int i = startNum; i <= endNum; i++)
            {
                oddSum = 0;
                evenSum = 0;
                position = 1;
                string currNum = i.ToString();
                for (int j = 0; j < currNum.Length; j++)
                {
                    char currDigit = currNum[j];
                    int currDigitConverted = int.Parse(currDigit.ToString());
                    if (position % 2 == 0)
                    {
                        evenSum += currDigitConverted;
                    }
                    else
                    {
                        oddSum += currDigitConverted;
                    }

                    position++;
                }
                if (oddSum == evenSum)
                {
                    Console.Write(currNum + " ");
                }
            }


        }

    }
}

