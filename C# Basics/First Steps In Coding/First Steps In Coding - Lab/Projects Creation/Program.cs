using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string archName = Console.ReadLine();
            int projectsNumber = int.Parse(Console.ReadLine());
            int hoursPerOneProject = 3;
            int hoursNeeded = projectsNumber * hoursPerOneProject;
            Console.WriteLine($"The architect {archName} will need {hoursNeeded} hours to complete {projectsNumber} project/s.");
        }
    }
}
