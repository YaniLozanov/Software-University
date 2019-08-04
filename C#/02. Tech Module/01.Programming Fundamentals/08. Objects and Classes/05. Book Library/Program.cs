using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Program
    {
        // Problem:
        // To model a book library, define classes to hold a book and a library. 
        // The library must have a name and a list of books.The books must contain the title, author, publisher, release date(in dd.MM.yyyy format), ISBN-number and price.
        // Read a list of books, add them to the library and print the total sum of prices by author, ordered descending by price and then by author’s name lexicographically.
        // Books in the input will be in format {title} {author} {publisher} {release date} {ISBN} {price}.
        // The total prices must be printed formatted to the second decimal place.

        static void Main(string[] args)
        {
            int booksCount = int.Parse(Console.ReadLine());
            List<Book> books = new List<Book>();

            for (int i = 0; i < booksCount; i++)
            {
                books.Add(ReadBook(Console.ReadLine()));
            }

            Library library = new Library { Name = "Library", Books = books };

            Dictionary<string, decimal> authors = new Dictionary<string, decimal>();

            foreach (Book book in library.Books)
            {
                if (authors.ContainsKey(book.Author))
                {
                    authors[book.Author] += book.Price;
                }
                else
                {
                    authors[book.Author] = book.Price;
                }
            }

            foreach (var pair in authors.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1:F2}", pair.Key, pair.Value);
            }
        }

        static Book ReadBook(string input)
        {
            string[] tokens = input.Split(' ');
            string title = tokens[0];
            string author = tokens[1];
            string publisher = tokens[2];
            DateTime releaseDate = DateTime.ParseExact(tokens[3], "d.M.yyyy", CultureInfo.InvariantCulture);
            string isbn = tokens[4];
            decimal price = decimal.Parse(tokens[5]);

            return new Book { Title = title, Author = author, Publisher = publisher, ReleaseDate = releaseDate, ISBN = isbn, Price = price };
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}