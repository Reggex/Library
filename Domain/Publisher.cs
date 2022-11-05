using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Publisher
    {

        public Publisher(string title, int year)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException(nameof(title));
            }

            this.Id = Guid.NewGuid();
            this.Title = title;
            this.Year = year;
        }

        public Publisher(string title, int year, ISet<Book> books)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException(nameof(title));
            }

          

            this.Id = Guid.NewGuid();
            this.Title = title;
            this.Year = year;
            this.Books = books;
        }

        public Guid Id { get; }

        public string Title { get; }

        public int Year { get; }

        public ISet<Book> Books { get; }

        public override string ToString()
        {
            return $" {Title} {Year}";
        }

    }
}
