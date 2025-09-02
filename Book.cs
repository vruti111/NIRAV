/*
Create a Book class with members bookId, bookTitle, bookAuthor, bookPrice.
Use the default constructor.
Display 5 books details in output (array of objects).
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIRAV;

class Book
{
    int bookId;
    string bookTitle;
    string bookAuthor;
    double bookPrice;
    // Default Constructor
    public Book()
    {
        Console.Write("Enter Book ID: ");
        bookId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Book Title: ");
        bookTitle = Console.ReadLine();
        Console.Write("Enter Book Author: ");
        bookAuthor = Console.ReadLine();
        Console.Write("Enter Book Price: ");
        bookPrice = Convert.ToDouble(Console.ReadLine());
    }
    // Display Method
    public void ShowDetails()
    {
        Console.WriteLine("Book ID: " + bookId);
        Console.WriteLine("Book Title: " + bookTitle);
        Console.WriteLine("Book Author: " + bookAuthor);
        Console.WriteLine("Book Price: " + bookPrice);
    }
}
internal class Ex_Constructor
{
    public static void Main(string[] args)
    {
        // Create an array of 5 Book objects
        Book[] books = new Book[5];
        // Initialize each book using the default constructor
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"Enter details for Book {i + 1}:");
            books[i] = new Book();
            Console.WriteLine();
        }
        // Display details of all books
        Console.WriteLine("Details of the Books:");
        foreach (var book in books)
        {
            book.ShowDetails();
            Console.WriteLine();
        }
    }
}