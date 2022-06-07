using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int daysNecesseryToReadTheWholeBook = int.Parse(Console.ReadLine());
            double totalTimeForReading = numberOfPages / pagesPerHour;
            double hoursNeeded = totalTimeForReading / daysNecesseryToReadTheWholeBook;
            Console.WriteLine(hoursNeeded);
        }
    }
}
