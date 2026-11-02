
using System;

// Part 1: Book class
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Isbn { get; set; }
    public bool IsAvailable { get; private set; }

    // Constructor initializes the book details
    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        Isbn = isbn;
        IsAvailable = true;
    }

    // Displays book information
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {Isbn}");
        Console.WriteLine($"Available: {IsAvailable}");
    }

    // Borrows the book if available
    public void Borrow()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"{Title} has been borrowed.");
        }
        else
        {
            Console.WriteLine($"{Title} is already borrowed.");
        }
    }

    // Returns the book
    public void Return()
    {
        IsAvailable = true;
        Console.WriteLine($"{Title} has been returned.");
    }
}

// Part 2: EBook inherits from Book
public class EBook : Book
{
    public double FileSizeMb { get; set; }

    // Constructor passes common properties to Book
    public EBook(string title, string author, string isbn, double fileSizeMb)
        : base(title, author, isbn)
    {
        FileSizeMb = fileSizeMb;
    }

    // Overrides DisplayInfo to include file size
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"File Size: {FileSizeMb} MB");
    }
}

// Part 3: Main program
class Program
{
    static void Main(string[] args)
    {
        // Create two Book objects and one EBook object
        Book book1 = new Book(
            "The Great Gatsby",
            "F. Scott Fitzgerald",
            "978-0743273565"
        );

        Book book2 = new Book(
            "To Kill a Mockingbird",
            "Harper Lee",
            "978-0061120084"
        );

        EBook ebook1 = new EBook(
            "Clean Code",
            "Robert C. Martin",
            "978-0132350884",
            5.5
        );

        // Display information for all three objects
        Console.WriteLine("===== BOOK 1 =====");
        book1.DisplayInfo();

        Console.WriteLine("\n===== BOOK 2 =====");
        book2.DisplayInfo();

        Console.WriteLine("\n===== EBOOK =====");
        ebook1.DisplayInfo();

        // Borrow the same book twice
        Console.WriteLine("\n===== BORROW BOOK =====");
        book1.Borrow();
        book1.Borrow();

        // Return the book and display its information
        Console.WriteLine("\n===== RETURN BOOK =====");
        book1.Return();
        book1.DisplayInfo();

        // Demonstrate polymorphism
        Console.WriteLine("\n===== POLYMORPHISM =====");
        Book polymorphicBook = ebook1;
        polymorphicBook.DisplayInfo();

        Console.WriteLine("\nProgram completed.");
    }
}

