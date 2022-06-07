using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookNeeded = Console.ReadLine();
            int bookCounter = 0;

            while (true)
            {
                string bookCheck = Console.ReadLine();
                if (bookCheck==bookNeeded)
                {
                    Console.WriteLine($"You checked {bookCounter} books and found it.");
                    break;
                }
                if (bookCheck=="No More Books")
                {
                    Console.WriteLine($"The book you search is not here!\nYou checked {bookCounter} books.");
                    break;
                }
                bookCounter++;
            }

        }
    }
}
