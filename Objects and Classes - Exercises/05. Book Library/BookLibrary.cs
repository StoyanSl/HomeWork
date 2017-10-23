using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class BookLibrary
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
                DateTime releaseDate = DateTime.ParseExact(entry[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string IsbnCode = entry[4];
                decimal price = decimal.Parse(entry[5]);
                Book book = new Book(title, author, publisher, releaseDate, IsbnCode, price);
                library.Books.Add(book);
            }
            var booksByAuthors = new Dictionary<string, List<Book>>();
           booksByAuthors= CreateBooksByAuthor(library, booksByAuthors);
            foreach (var authorEntry in booksByAuthors.OrderByDescending(x=>x.Value.Select(p=>p.price).Sum()).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{authorEntry.Key} -> {authorEntry.Value.Select(p => p.price).Sum():f2}");
            }
            foreach (var book in library.Books)
            {
               
            }
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
        public Dictionary<string, int> TestDictionary { get; set; }
    }
    }

