using System;

namespace Scolarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double avgGrade = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double scholarship5 = Math.Floor(avgGrade * 25.00);
            double scholarship4 = Math.Floor(minimalSalary * 0.35);

            if (income < minimalSalary)
            {
                if (avgGrade > 4.50 && avgGrade < 5.50)
                {
                    Console.WriteLine($"You get a Social scholarship {scholarship4} BGN");
                }
                else if (avgGrade >= 5.50 && scholarship5 >= scholarship4)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {scholarship5} BGN");
                }
                else if (avgGrade >= 5.50 && scholarship5 < scholarship4)
                {
                    Console.WriteLine($"You get a Social scholarship {scholarship4} BGN");
                }
                else
                {
                    Console.WriteLine($"You cannot get a scholarship!");
                }
            }
            else
            {
                if (avgGrade >= 5.50)
                {

                    Console.WriteLine($"You get a scholarship for excellent results {scholarship5} BGN");
                }
                else
                {
                    Console.WriteLine($"You cannot get a scholarship!");
                }
            }
        }
    }
}
