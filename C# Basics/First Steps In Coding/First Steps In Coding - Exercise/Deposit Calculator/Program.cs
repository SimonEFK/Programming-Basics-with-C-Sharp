using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            double depositPeriod = double.Parse(Console.ReadLine());
            double anuallInterestPercentage = double.Parse(Console.ReadLine());
            double percentageFormula = anuallInterestPercentage / 100;
            double totalInterest = deposit * percentageFormula;
            double interestPorOneMonth = totalInterest / 12;
            double totalSum = deposit + (depositPeriod * interestPorOneMonth);
            Console.WriteLine(totalSum);







        }
    }
}
