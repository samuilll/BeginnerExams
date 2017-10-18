using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task05BookLibrary
{
    class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string ISBN { get; set; }

        public double Price { get; set; }

        public Book(string t, string a, string p, DateTime r, string i, double pr)
        {
            this.Title = t; this.Author = a; this.Publisher = p; this.ReleaseDate = r; this.ISBN = i; this.Price = pr;
        }
    }
    class Task05BookLibrary
    {
        static void Main(string[] args)
        {
            var toRepeat = int.Parse(Console.ReadLine());

            List<Book> Library = new List<Book>();

            for (int i = 0; i < toRepeat; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var title = input[0];

                var author = input[1];

                var publisher = input[2];

                var releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy",CultureInfo.InvariantCulture);

                var ISBN = input[4];

                var price = double.Parse(input[5]);

                var currentBook = new Book(title,author,publisher,releaseDate,ISBN,price);

                Library.Add(currentBook);

            }

            List<string> authors = Library.Select(n => n.Author).Distinct().ToList();

            Dictionary<string, double> ouput = new Dictionary<string, double>();

            foreach (var author in authors)
            {
              ouput[author] = Library.Where(n=>n.Author==author).Select(n=>n.Price).Sum();
            }

            foreach (var author in ouput.OrderByDescending(n=>n.Value).ThenBy(n=>n.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }

            
        }
    }
}
