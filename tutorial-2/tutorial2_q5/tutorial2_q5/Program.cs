using System;
using System.Collections.Generic;

class LibraryBook
{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool Available { get; set; }

    public LibraryBook(string title, string author)
    {
        Title = title;
        Author = author;
        Available = true;
    }

    public void BorrowBook()
    {
        if (Available)
        {
            Available = true;
            Console.WriteLine($"Book '{Title}' by {Author} has been borrowed.");
        }
        else
        {
            Console.WriteLine($"Book '{Title}' by {Author} is not available for borrowing.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        LibraryBook book1 = new LibraryBook("Madol Duwa", "Martin Wickramasinghe");
        LibraryBook book2 = new LibraryBook("Sherlock Holmes", "Sasith Bandara");
        LibraryBook book3 = new LibraryBook("Hath Pana", "Kumarathunga Munidasa");

        book1.BorrowBook();
        book2.BorrowBook();
        book3.BorrowBook();

        Console.WriteLine($"Madol Duwa availability: {book1.Available}");
        Console.WriteLine($"Sherlock Holmes availability: {book2.Available}");
        Console.WriteLine($"Hath Pana availability: {book3.Available}");
    }
}
