using System;

namespace NIRAV
{
    public class Book29
    {
        private int bookId;
        private string title;
        private string author;
        private int pages;
        private double originalPrice;

        public Book29(int bookId, string title, string author, int pages, double originalPrice)
        {
            this.bookId = bookId;
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.originalPrice = originalPrice;
        }

        public double CalculateDiscountedPrice()
        {
            double discount = 0;

            if (pages < 300)
            {
                discount = 0.20 * originalPrice;
            }
            else if (pages < 500)
            {
                discount = 0.30 * originalPrice;
            }
            else
            {
                discount = 0.10 * originalPrice;
            }

            return originalPrice - discount;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Book ID: {bookId}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Pages: {pages}");
            Console.WriteLine($"Original Price: {originalPrice:C}");
            Console.WriteLine($"Final Price After Discount: {CalculateDiscountedPrice():C}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book29[] books = new Book29[3];

            books[0] = new Book29(101, "Mathe", "Mayan", 450, 500);
            books[1] = new Book29(102, "Science", "Nirav", 250, 400);
            books[2] = new Book29(103, "History", "Raj", 600, 800);

            Console.WriteLine("All Books:\n");
            foreach (Book29 b in books)
            {
                b.DisplayDetails();
            }

            
            Book29 cheapestBook = books[0];
            foreach (Book29 b in books)
            {
                if (b.CalculateDiscountedPrice() < cheapestBook.CalculateDiscountedPrice())
                {
                    cheapestBook = b;
                }
            }

            Console.WriteLine("📚 Book with the Lowest Final Price:\n");
            cheapestBook.DisplayDetails();

            Console.ReadLine();
        }
    }
}
