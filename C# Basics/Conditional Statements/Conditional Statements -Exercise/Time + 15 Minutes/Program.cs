using System;

namespace Time15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine()) + 15;

            if (minutes > 59)
            {
                hours++;
                minutes -= 60;
            }
            if (hours >= 24)
            {
                hours = 0;
            }
            if (minutes <= 9)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else if (minutes >= 10)
            {
                Console.WriteLine($"{hours}:{minutes}");
            }

        }
    }
}
