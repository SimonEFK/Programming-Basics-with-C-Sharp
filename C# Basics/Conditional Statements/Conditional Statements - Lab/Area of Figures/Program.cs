using System;

namespace AreaFig
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double sideLenght = double.Parse(Console.ReadLine());
                double squareArea = sideLenght * sideLenght;
                Console.WriteLine($"{squareArea:F3}");
            }
            else if (figure == "rectangle")
            {
                double rectAngleSide1 = double.Parse(Console.ReadLine());
                double rectAngleSide2 = double.Parse(Console.ReadLine());
                double areaOfRectangle = rectAngleSide1 * rectAngleSide2;
                Console.WriteLine($"{areaOfRectangle:F3}");
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double areCircle = Math.PI * (r * r);
                Console.WriteLine($"{areCircle:F3}");
            }
            else if (figure == "triangle")
            {
                double triangleneznamsikvo = double.Parse(Console.ReadLine());
                double trianglebalsummumakata = double.Parse(Console.ReadLine());
                double triangleArea = (triangleneznamsikvo * trianglebalsummumakata) / 2;
                Console.WriteLine($"{triangleArea:F3}");
            }

        }
    }
}
