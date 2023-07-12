using System;
using System.Collections.Generic;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
}

public class LibraryManagementSystem
{
    private List<Book> books;

    public LibraryManagementSystem()
    {
        books = new List<Book>();
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Update Book");
            Console.WriteLine("4. Delete Book");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    ViewBooks();
                    break;
                case "3":
                    UpdateBook();
                    break;
                case "4":
                    DeleteBook();
                    break;
                case "5":
                    Console.WriteLine("Exiting the Library Management System...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public void AddBook()
    {
        Console.WriteLine("Adding a new book...");

        Console.Write("Enter book title: ");
        string title = Console.ReadLine();

        Console.Write("Enter book author: ");
        string author = Console.ReadLine();

        Console.Write("Enter publication year: ");
        int year = int.Parse(Console.ReadLine());

        Book newBook = new Book
        {
            Id = GetNextId(),
            Title = title,
            Author = author,
            Year = year
        };

        books.Add(newBook);
        Console.WriteLine("Book added successfully.");
    }

    public void ViewBooks()
    {
        Console.WriteLine("Listing all books...");

        if (books.Count == 0)
        {
            Console.WriteLine("No books found.");
        }
        else
        {
            Console.WriteLine("ID\tTitle\t\tAuthor\t\tYear");
            Console.WriteLine("----------------------------------------");
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id}\t{book.Title}\t{book.Author}\t\t{book.Year}");
            }
        }
    }

    public void UpdateBook()
    {
        Console.WriteLine("Updating a book...");

        Console.Write("Enter book ID: ");
        int id = int.Parse(Console.ReadLine());

        Book bookToUpdate = books.Find(b => b.Id == id);
        if (bookToUpdate == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        Console.Write("Enter updated book title: ");
        string title = Console.ReadLine();

        Console.Write("Enter updated book author: ");
        string author = Console.ReadLine();

        Console.Write("Enter updated publication year: ");
        int year = int.Parse(Console.ReadLine());

        bookToUpdate.Title = title;
        bookToUpdate.Author = author;
        bookToUpdate.Year = year;

        Console.WriteLine("Book updated successfully.");
    }

    public void DeleteBook()
    {
        Console.WriteLine("Deleting a book...");

        Console.Write("Enter book ID: ");
        int id = int.Parse(Console.ReadLine());

        Book bookToDelete = books.Find(b => b.Id == id);
        if (bookToDelete == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        books.Remove(bookToDelete);
        Console.WriteLine("Book deleted successfully.");
    }

    private int GetNextId()
    {
        int maxId = 0;
        foreach (var book in books)
        {
            if (book.Id > maxId)
            {
                maxId = book.Id;
            }
        }
        return maxId + 1;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        LibraryManagementSystem librarySystem = new LibraryManagementSystem();
        librarySystem.Run();
    }
}
