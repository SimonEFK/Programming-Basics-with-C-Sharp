﻿using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            //double p4 = 0;
            //double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }
                //else if (num >= 600 && num < 800)
                //{
                //    p4++;
                //}
                //else if (num >= 800)
                //{
                //    p5++;
                //}
            }
            double percentage1 = p1 / n * 100;
            double percentage2 = p2 / n * 100;
            double percentage3 = p3 / n * 100;
            //double percentage4 = p4 / n * 100;
            //double percentage5 = p5 / n * 100;
            Console.WriteLine($"{percentage1:f2}% \n{percentage2:f2}% \n{percentage3:f2}%"); //\n{percentage4:f2}% \n{percentage5:f2}%");
        }
    }
}
