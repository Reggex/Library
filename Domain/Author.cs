
namespace Domain
{

    public class Author
    {

        public Guid Id { get; }

        public string FirstName { get; }

        public string LastName { get; }

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