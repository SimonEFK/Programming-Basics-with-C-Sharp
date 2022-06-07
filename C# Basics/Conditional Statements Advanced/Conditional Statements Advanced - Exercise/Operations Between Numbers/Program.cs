using System;

namespace oneTime
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = int.Parse(Console.ReadLine());
            double n2 = int.Parse(Console.ReadLine());
            string function = Console.ReadLine();
            double sum = 0;

            switch (function)
            {
                case "+":
                    sum = n1 + n2;
                    if (sum % 2 == 0)
                        Console.WriteLine($"{n1} + {n2} = {sum} - even");
                    else
                    {
                        Console.WriteLine($"{n1} + {n2} = {sum} - odd");
                    }
                    break;
                case "-":
                    sum = n1 - n2;
                    if (sum % 2 == 0)
                        Console.WriteLine($"{n1} - {n2} = {sum} - even");
                    else
                    {
                        Console.WriteLine($"{n1} - {n2} = {sum} - odd");
                    }
                    break;
                case "*":
                    sum = n1 * n2;
                    if (sum % 2 == 0)
                        Console.WriteLine($"{n1} * {n2} = {sum} - even");
                    else
                    {
                        Console.WriteLine($"{n1} * {n2} = {sum} - odd");
                    }
                    break;
                case "/":
                    sum = n1 / n2;
                    if (n1 == 0 || n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} / {n2} = {sum:f2}");
                    }
                    break;
                case "%":
                    sum = n1 % n2;
                    if (n1 == 0 || n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} % {n2} = {sum}");
                    }
                    break;
                default:
                    break;
            }


        }
    }
}
