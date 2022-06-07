using System;

namespace OnTimefortheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examH = int.Parse(Console.ReadLine());
            int examM = int.Parse(Console.ReadLine());
            int arrivalH = int.Parse(Console.ReadLine());
            int arrivalM = int.Parse(Console.ReadLine());

            int examTime = (examH * 60) + examM;
            int arrivalTime = (arrivalH * 60) + arrivalM;
            int diff = 0;
            int diffH = 0;
            int diffM = 0;

            if (arrivalTime > examTime)
            {
                Console.WriteLine("Late");
                diff = arrivalTime - examTime;
                diffH = diff / 60;
                diffM = diff % 60;
                if (diffH <= 0)
                {
                    Console.WriteLine($"{diffM} minutes after the start");
                }
                else
                {
                    if (diffM < 10)
                    {
                        Console.WriteLine($"Late\n{diffH}:0{diffM} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"Late\n{diffH}:{diffM} hours after the start");
                    }

                }
            }
            else if (arrivalTime < examTime)
            {
                diff = examTime - arrivalTime;
                diffH = diff / 60;
                diffM = diff % 60;
                if (diffM <= 30 && diffH <= 0)
                {
                    Console.WriteLine($"On time\n{diffM} minutes before the start");
                }
                else if (diffH <= 0)
                {
                    Console.WriteLine($"Early\n{diffM} minutes before the start");
                }
                else
                {
                    if (diffM < 10)
                    {
                        Console.WriteLine($"Early\n{diffH}:0{diffM} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"Early\n{diffH}:{diffM} hours before the start");
                    }

                }
            }
            else
            {
                Console.WriteLine("On time");
            }
        }
    }
}
