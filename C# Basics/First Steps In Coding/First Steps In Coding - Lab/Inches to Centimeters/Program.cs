using System;

namespace inchtocm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cm to inches converter");
            double inch = double.Parse(Console.ReadLine());
            double cm = inch * 2.54;
            Console.WriteLine(cm);
        }
    }
}
