using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerOneMeter = double.Parse(Console.ReadLine());
            double timeWithoutDelay = distance * timePerOneMeter;
            double deley = Math.Floor(distance / 15) * 12.5;
            double timeWithDelay = timeWithoutDelay + deley;
            double timeNeeded = timeWithDelay - record;
            double newRecord = timeWithDelay;
            if (timeWithDelay < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {newRecord:f2} seconds.");
            }
            else if (timeWithDelay >= record)
            {
                Console.WriteLine($"No, he failed! He was {timeNeeded:f2} seconds slower.");
            }
        }
    }
}
