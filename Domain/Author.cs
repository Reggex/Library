
namespace Domain
{
    /// <summary>
    /// Автор
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string? MiddleName { get; }

        public ISet<Book> Books { get; } = new HashSet<Book>();


        public Author(string lastName, string firstName, 
            string? middleName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentNullException(nameof(firstName));
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentNullException(nameof(lastName));
            }

            if ((middleName?.Trim())?.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(middleName));
            }
            this.Id = Guid.NewGuid();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
        }


        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName}";
        }
    }
}