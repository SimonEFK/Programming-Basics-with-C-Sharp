using System;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = string.Empty;
            string seats = string.Empty;
            string type = string.Empty;
            double totalTickets = 0;
            bool isMovieFinish = false;
            double totalTicketsForAll = 0;
            double totalTicketsForStudents = 0;
            double totalTicketsForStandard = 0;
            double totalTicketsForKids = 0;

            while (isMovieFinish == false)
            {
                double studentTCount = 0;
                double standardTCount = 0;
                double kidCount = 0;
                movie = Console.ReadLine();
                if (movie == "Finish")
                {
                    isMovieFinish = true;
                    break;
                }
                seats = Console.ReadLine();
                double seatsNum = double.Parse(seats);
                for (int i = 1; i <= seatsNum; i++)
                {
                    type = Console.ReadLine();
                    if (type == "End")
                    {
                        break;
                    }
                    if (type == "student")
                    {
                        studentTCount++;
                    }
                    else if (type == "standard")
                    {
                        standardTCount++;
                    }
                    else if (type == "kid")
                    {
                        kidCount++;
                    }
                }
                totalTickets = studentTCount + standardTCount + kidCount;
                double percFormula = totalTickets / seatsNum * 100;
                Console.WriteLine($"{movie} - {percFormula:f2}% full.");
                totalTicketsForAll += totalTickets;
                totalTicketsForStudents += studentTCount;
                totalTicketsForStandard += standardTCount;
                totalTicketsForKids += kidCount;

            }


            Console.WriteLine($"Total tickets: {totalTicketsForAll}\n{totalTicketsForStudents / totalTicketsForAll * 100:f2}% student tickets.\n{totalTicketsForStandard / totalTicketsForAll * 100:f2}% standard tickets.\n{totalTicketsForKids / totalTicketsForAll * 100:f2}% kids tickets.");

        }
    }
}
