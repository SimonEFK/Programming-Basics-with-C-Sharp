using System;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNumStop = false;
            string currNum = string.Empty;
            double currNumConverted = 0;
            double primeSum = 0;
            double nonPrimeSum = 0;
            while (!isNumStop)
            {
                currNum = Console.ReadLine();
                if (currNum == "Stop")
                {
                    goto loopEnd;
                }
                currNumConverted = double.Parse(currNum);

                if (currNumConverted % currNumConverted == 0)
                {
                    primeSum += currNumConverted;
                }
                else
                {
                    nonPrimeSum += currNumConverted;
                }
            }

        loopEnd:
            {
                Console.WriteLine($"Sum of all prime numbers is: {primeSum}\nSum of all non prime numbers is:{nonPrimeSum}");

            }
        }
    }
}
