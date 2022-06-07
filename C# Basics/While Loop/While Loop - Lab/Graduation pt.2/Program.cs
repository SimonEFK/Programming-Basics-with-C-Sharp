using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int gradesCounter = 0;
            int badGradesCounter = 0;
            double gradesSum = 0;
            double avgGrade = 0;
            int excludedGrade = 0;
            int allgrades = 0;
            int gradeCounter = 0;

            while (true)
            {
                double grade = double.Parse(Console.ReadLine());
                gradeCounter++;
                if (grade < 4)
                {
                    badGradesCounter++;
                }
                else
                {
                    gradesCounter++;
                }
                allgrades = badGradesCounter + gradesCounter;
                gradesSum += grade;
                avgGrade = gradesSum / allgrades;
                if (badGradesCounter > 1)
                {
                    Console.WriteLine($"{studentName} has been excluded at {gradeCounter - 1} grade");
                    break;
                }
                if (gradeCounter >= 12)
                {
                    Console.WriteLine($"{studentName} graduated. Average grade: {avgGrade:f2}");
                    break;
                }
            }
            //Console.WriteLine($"{studentName} graduated. Average grade: {avgGrade:f2}");
        }
    }
}
