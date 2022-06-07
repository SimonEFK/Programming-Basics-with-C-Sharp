using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int totalSteps = 0;
            int lastSteps = 0;
            string steps = string.Empty;
            //int lastSteps = 0;

            while (totalSteps<goal)
            {

                steps = Console.ReadLine();
                if (steps == "Going home")
                {
                    lastSteps = int.Parse(Console.ReadLine());
                    totalSteps += lastSteps;
                    if (totalSteps >= goal)
                    {
                        totalSteps -= goal;
                        Console.WriteLine($"Goal reached! Good job!\n{totalSteps} steps over the goal!");
                        return;
                    }
                    else
                    {
                        goal -= totalSteps;
                        Console.WriteLine($"{goal} more steps to reach goal.");
                        return;
                    }

                }
                int newsteps = int.Parse(steps);
                totalSteps += newsteps;                
            }
            Console.WriteLine($"Goal reached! Good job!\n{Math.Abs(goal-totalSteps)} steps over the goal!");
        }
    }
}
