using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int fCount = 0;
            int iCount = 0;
            int rCount = 0;
            int fine = 0;
            int salaryLeft = 0;
            for (int i = 0; i < tabs; i++)
            {
                string site = Console.ReadLine().ToLower();

                if (site == "facebook")
                {
                    fCount++;
                }
                else if (site == "instagram")
                {
                    iCount++;
                }
                else if (site == "reddit")
                {
                    rCount++;
                }

            }
            fine = (fCount * 150) + (iCount * 100) + (rCount * 50);
            salaryLeft = salary - fine;
            if (fine >= salary)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine($"{salaryLeft}");
            }


        }
    }
}
