using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widght = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int boxesAmount = 0;
            int boxesCubeM = 0;
            int diff = 0;

            int roomsCubicMeters = widght * lenght * height;

            while (true)
            {
                string boxes = Console.ReadLine();
                if (boxes=="Done")
                {
                    Console.WriteLine($"{diff} Cubic meters left.");
                    break;
                }
                boxesCubeM = int.Parse(boxes);
                boxesAmount += boxesCubeM;
                diff = roomsCubicMeters - boxesAmount;
                if (diff<0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(diff)} Cubic meters more.");
                    break;
                }                
            }
        }
    }
}
