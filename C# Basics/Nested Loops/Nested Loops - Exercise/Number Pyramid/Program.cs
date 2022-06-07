using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int rows = 1;
            int cols = 1;
            int numToPrint = 1;

            while (numToPrint <= num)
            {
                for (int i = 1; i <= cols; i++)
                {
                    Console.Write(numToPrint +" ");
                    if (numToPrint==num)
                    {
                        return;
                    }
                    numToPrint++;
                }
                cols++;
                Console.WriteLine();
            }
        }
    }
}
