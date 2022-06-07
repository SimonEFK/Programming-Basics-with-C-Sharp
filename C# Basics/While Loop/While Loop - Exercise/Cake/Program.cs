using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());

            int cakeArea = cakeWidth * cakeLength;
            int totalCakePieces = 0;

            while (totalCakePieces<cakeArea)
            {
                string cakeTaken = Console.ReadLine();
                if (cakeTaken=="STOP")
                {
                    Console.WriteLine($"{Math.Abs(totalCakePieces-cakeArea)} pieces are left.");
                    return;
                }
                int Cake = int.Parse(cakeTaken);
                totalCakePieces += Cake;
            }
         Console.WriteLine($"No more cake left! You need {totalCakePieces-cakeArea} pieces more.");
        }
    }
}
