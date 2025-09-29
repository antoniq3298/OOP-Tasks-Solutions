using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public override string ToString()
    {
        return $"{Title} by {Author} ({Year})";
    }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book) => books.Add(book);

    public bool RemoveBook(string title)
    {
        var book = books.FirstOrDefault(b => b.Title == title);
        if (book != null)
        {
            books.Remove(book);
            return true;
        }
        return false;
    }

    public List<Book> FindByAuthor(string author)
    {
        return books.Where(b => b.Author == author).ToList();
    }

    public void ListAll()
    {
        if (books.Count == 0)
            Console.WriteLine("Library is empty.");
        else
            books.ForEach(b => Console.WriteLine(b));
    }
}

class Program
{
    static void Main()
    {
        var library = new Library();
        library.AddBook(new Book { Title = "1984", Author = "George Orwell", Year = 1949 });
        library.AddBook(new Book { Title = "Animal Farm", Author = "George Orwell", Year = 1945 });
        library.AddBook(new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien", Year = 1937 });

        Console.WriteLine("All books:");
        library.ListAll();

        Console.WriteLine("\nBooks by Orwell:");
        library.FindByAuthor("George Orwell").ForEach(Console.WriteLine);

        library.RemoveBook("1984");
        Console.WriteLine("\nAfter removing 1984:");
        library.ListAll();
    }
}
