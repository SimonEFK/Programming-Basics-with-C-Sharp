using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failGrade = int.Parse(Console.ReadLine());
            int gradeStorage = 0;
            int gradeCounter = 0;
            string lastProblem = string.Empty;
            int badGradesCounter = 0;
            double avgGrade = 0;
            int ExamCounter = 0;

            while (true)
            {
                
                string ExamName = Console.ReadLine();
                if (ExamName=="Enough")
                {
                    Console.WriteLine($"Average score: {avgGrade:f2}\nNumber of problems: {ExamCounter}\nLast problem: {lastProblem}");
                    break;
                }
                ExamCounter++;
                lastProblem = ExamName;               
                int grade = int.Parse(Console.ReadLine());
                gradeStorage += grade;
                gradeCounter++;
                avgGrade = 1.0 * gradeStorage / gradeCounter;
                if (grade<=4)
                {
                    badGradesCounter++;
                }
                if (badGradesCounter==failGrade)
                {
                    Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
                    break;

                }             
            }

        }
    }
}
