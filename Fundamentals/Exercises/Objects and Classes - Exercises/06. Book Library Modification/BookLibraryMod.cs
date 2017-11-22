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
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Library library = new Library("New Library");
            for (int i = 0; i < n; i++)
            {
                var entry = Console.ReadLine().Split(' ').ToList();
                string title = entry[0];
                string author = entry[1];
                string publisher = entry[2];
                DateTime releaseDate = DateTime.ParseExact(entry[3],"d.M.yyyy", CultureInfo.InvariantCulture);
                string IsbnCode = entry[4];
                decimal price = decimal.Parse(entry[5]);
                Book book = new Book(title, author, publisher, releaseDate, IsbnCode, price);
                library.Books.Add(book);
            }
            DateTime datecmp=DateTime.ParseExact(Console.ReadLine(),"d.M.yyyy",CultureInfo.InvariantCulture);
            var booksByAuthors = new Dictionary<string, List<Book>>();
            var booksByRealeaseDate = new Dictionary<string, DateTime>();
            booksByAuthors = CreateBooksByAuthor(library, booksByAuthors);
            booksByRealeaseDate = FillsBooksByAuthor(booksByAuthors, booksByRealeaseDate);
            foreach (var book in booksByRealeaseDate.OrderBy(s=>s.Value).ThenBy(s=>s.Key))
            {
                if (datecmp<book.Value)
                {
                    Console.WriteLine($"{book.Key} -> {book.Value:d.MM.yyyy}");
                }
               
            }
        }

         static Dictionary<string, DateTime> FillsBooksByAuthor(Dictionary<string, List<Book>> booksByAuthors, Dictionary<string, DateTime> booksByRealeaseDate)
        {
            foreach (var listValue in booksByAuthors.Values)
            {
                foreach (var book in listValue)
                {
                    if (!booksByRealeaseDate.ContainsKey(book.title))
                    {
                        booksByRealeaseDate.Add(book.title, DateTime.MinValue);
                    }
                    booksByRealeaseDate[book.title] = book.releaseDate;
                }
            }
            return booksByRealeaseDate;
        }

        static  Dictionary<string, List<Book>> CreateBooksByAuthor(Library library, Dictionary<string, List<Book>> booksByAuthors)
        {
            foreach (var book in library.Books)
            {
                if (!booksByAuthors.ContainsKey(book.author))
                {
                    booksByAuthors.Add(book.author, new List<Book>());
                }
                booksByAuthors[book.author].Add(book);
            }
            return booksByAuthors;
        }
    }

    class Library
    {
        public Library(string name)
        {
            this.name = name;
           this.Books=new List<Book>();
        }

        public string name { get; set; }
        public List<Book> Books { get; set; }
    }
    class Book
    {
       public Book(string title,string author,string publisher,DateTime releaseDate, string IsbnCode,decimal price)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.releaseDate = releaseDate;
            this.IsbnCode = IsbnCode;
            this.price = price;
        }
        public string title { get ; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public DateTime releaseDate { get; set; }
        public string IsbnCode { get; set; }
        public decimal price { get; set; }
    }
    }

