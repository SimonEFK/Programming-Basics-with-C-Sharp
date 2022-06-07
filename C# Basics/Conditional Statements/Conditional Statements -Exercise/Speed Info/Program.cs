using System;

namespace speedInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            double sonic = double.Parse(Console.ReadLine());
            if (sonic <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (sonic > 10 && sonic <= 50)
            {
                Console.WriteLine("average");
            }
            else if (sonic > 50 && sonic <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (sonic > 150 && sonic <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else if (sonic > 1000 && sonic <= 8000)
            {
                Console.WriteLine("extremely fast");
            }
            else if (sonic >= 9000)
            {
                Console.WriteLine("OVER 9000 THOUSAND!!!!!!!");
            }

        }
    }
}

