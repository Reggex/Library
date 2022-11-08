using System;

namespace Domain
{
    /// <summary>
    /// Книга
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; }

        public ISet<Author> Authors { get; } = new HashSet<Author>();

        public Publisher Publisher { get; set; }


        public Book(string title, ISet<Author> authors, Publisher publisher)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException("name");
            }

            this.Id = Guid.NewGuid();
            this.Title = title;
            this.Authors = authors;
            this.Publisher = publisher;
        }

        public virtual bool AddBookWithPublisher(Publisher publisher)
        {
            this.Publisher?.Books.Remove(this);

            this.Publisher = publisher ?? throw new ArgumentNullException(nameof(publisher));

            this.Publisher = publisher;

            return this.Publisher.Books.Add(this);
        }

        public Book(string title, params Author[] authors) 
            : this(title, new HashSet<Author>(authors), null!)
        {
        }

        public override string ToString()
        {
            return $"{this.Title} {string.Join(", ", this.Authors)} {string.Join(", ", this.Publisher)}";
        }
    }
}
