using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {

            int minValue = int.MaxValue;

            while (true)
            {
                string num = Console.ReadLine();//.ToLower();
                if (num == "Stop")
                {
                    break;
                }
                int stringToNumber = int.Parse(num);
                if (stringToNumber < minValue)
                {
                    minValue = stringToNumber;
                }

            }
            Console.WriteLine($"{minValue}");
        }
    }
}
