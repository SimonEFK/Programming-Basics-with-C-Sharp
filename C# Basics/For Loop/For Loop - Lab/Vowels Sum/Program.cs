﻿using System;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            //int a = 0;
            //int e = 0;
            //int ii = 0;
            //int o = 0;
            //int u = 0;
            int sum = 0;

            for (int i = 0; i <= word.Length - 1; i++)
            {

                if (word[i] == 'a')
                {
                    sum += 1;
                }
                if (word[i] == 'e')
                {
                    sum += 2;
                }
                if (word[i] == 'i')
                {
                    sum += 3;
                }
                if (word[i] == 'o')
                {
                    sum += 4;
                }
                if (word[i] == 'u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine($"{sum}");
        }
    }
}
