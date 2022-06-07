using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {

            int MaxValue = int.MinValue;

            while (true)
            {
                string num = Console.ReadLine();//.ToLower();
                if (num == "Stop")
                {
                    break;
                }
                int stringToNumber = int.Parse(num);
                if (stringToNumber > MaxValue)
                {
                    MaxValue = stringToNumber;
                }

            }
            Console.WriteLine($"{MaxValue}");
        }
    }
}
