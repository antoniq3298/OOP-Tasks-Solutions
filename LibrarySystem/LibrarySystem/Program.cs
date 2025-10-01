using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Title} by {Author}, {Year}";
    }
}

public class EBook : Book
{
    public double FileSize { get; set; } // in MB

    public EBook(string title, string author, int year, double fileSize)
        : base(title, author, year)
    {
        FileSize = fileSize;
    }

    public override string ToString()
    {
        return base.ToString() + $" [File size: {FileSize}MB]";
    }
}

// Example usage
class Program
{
    static void Main()
    {
        Book book = new Book("The Hobbit", "J.R.R. Tolkien", 1937);
        EBook ebook = new EBook("Clean Code", "Robert C. Martin", 2008, 5.4);

        Console.WriteLine(book);
        Console.WriteLine(ebook);
    }
}
