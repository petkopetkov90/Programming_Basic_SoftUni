using System;

namespace Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();

            int bookChecked = 0;

            while (true)
            {
                string bookCheck = Console.ReadLine();

                if (bookCheck == book)
                {
                    Console.WriteLine($"You checked {bookChecked} books and found it.");
                    break;
                }
                if (bookCheck == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {bookChecked} books.");
                    break;
                }

                bookChecked++;
            }

        }
    }
}