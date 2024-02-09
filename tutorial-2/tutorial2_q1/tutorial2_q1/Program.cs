using System;

namespace tutorial2_q1
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = "Madol Doowa";
            book.Author = "Martin Wickramasinghe";

            Console.WriteLine("Book Title: " + book.Title);
            Console.WriteLine("Book Author: " + book.Author);
        }
    }
}
