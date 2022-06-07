using System;

namespace CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();//.ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]}");
            }
        }
    }
}
