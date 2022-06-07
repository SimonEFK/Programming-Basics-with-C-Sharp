using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfDogs = double.Parse(Console.ReadLine());
            double numberOfOtherAnimals = double.Parse(Console.ReadLine());
            double costForDogsFood = 2.50;
            double costForOtherAnimalsFood = 4.00;
            double costForDogsAndOtherAnimals = numberOfDogs * costForDogsFood + numberOfOtherAnimals * costForOtherAnimalsFood;
            Console.WriteLine($"{costForDogsAndOtherAnimals} lv.");
        }
    }
}
