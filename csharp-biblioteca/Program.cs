namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library bibliotecaCentrale = new Library();
            bibliotecaCentrale.AddLibraryItem(new Book("BOOKPL90A34", "Il nome della Rosa", 1970, "Romance", "A420", "Umberto Eco", 800));
            bibliotecaCentrale.AddLibraryItem(new Dvd("DVD434564", "Berlin Calling", 2011, "Documentary", "D120", "Paul Kalkbrenner", new TimeSpan(0, 1, 35, 00)));
            Book book1 = new Book("BOOKAB12C34", "1984", 1949, "Dystopian", "A123", "George Orwell", 328);
            Book book2 = new Book("BOOKCD23E45", "To Kill a Mockingbird", 1960, "Fiction", "B234", "Harper Lee", 281);
            Book book3 = new Book("BOOKEF34G56", "Pride and Prejudice", 1813, "Classic", "C345", "Jane Austen", 432);
            Book book4 = new Book("BOOKFG45H67", "The Catcher in the Rye", 1951, "Fiction", "D456", "J.D. Salinger", 224);
            Book book5 = new Book("BOOKGH56I78", "The Great Gatsby", 1925, "Classic", "E567", "F. Scott Fitzgerald", 180);
            Book book6 = new Book("BOOKHI67J89", "The Hobbit", 1937, "Fantasy", "F678", "J.R.R. Tolkien", 310);
            Book book7 = new Book("BOOKIJ78K90", "Brave New World", 1932, "Dystopian", "G789", "Aldous Huxley", 325);
            Book book8 = new Book("BOOKJK89L01", "The Lord of the Rings", 1954, "Fantasy", "H890", "J.R.R. Tolkien", 1178);
            Book book9 = new Book("BOOKKL90M12", "Crime and Punishment", 1866, "Classical Fiction", "I901", "Fyodor Dostoevsky", 671);

            List<Book> books = new() { book1, book2, book3, book4, book5, book6, book7, book8, book9 };

            foreach (Book book in books)
            {
                bibliotecaCentrale.AddLibraryItem(book);
            }


            bibliotecaCentrale.PrintLibraryItems();
            Console.WriteLine();

            bibliotecaCentrale.GetItemFromCode("BOOKPL90A34");
            Console.WriteLine();
            Console.WriteLine(bibliotecaCentrale.GetItemFromTitle("The Hobbit"));
            Console.WriteLine();
            Console.WriteLine(bibliotecaCentrale.GetItemFromTitle("The Hike"));
            Console.WriteLine();
            Console.WriteLine(book5.ToString());
            Console.WriteLine();
            User user1 = new User("Rossi", "Mario", "rossimario@mail.com", "xxxxxxxx", "3405434566");
            bibliotecaCentrale.AddUser(user1);
            bibliotecaCentrale.AddLoan(book1, user1);
            bibliotecaCentrale.PrintLoanFromUserNameAndSurname("Rossi Mario");

        }
    }
}