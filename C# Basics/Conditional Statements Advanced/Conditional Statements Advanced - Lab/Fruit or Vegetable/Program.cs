using System;

namespace FruitorNah
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToLower();

            if (s == "banana" || s == "apple" || s == "kiwi" || s == "cherry" || s == "lemon" || s == "grapes")
            {
                Console.WriteLine("fruit");

            }
            else if (s == "tomato" || s == "cucumber" || s == "pepper" || s == "carrot" || s == "potato" || s == "grapes")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
