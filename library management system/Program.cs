using System.ComponentModel;

namespace library_management_system
{ 
    class Library
    {
        List<Book> books = new List<Book>();

        public Library(List<Book> books)
        {
            this.books = books;
        }
        public string Addbook(string title, string author, int iSBN, bool availbillity)
        {
            Book book = new Book(title, author, iSBN, availbillity);
            books.Add(book);
            return "Book added successfully";
        }
         public string SearchBook(string title ,string author)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title == title || books[i].author == author)
                {
                    return $"Book: {books[i].title} and author{books[i].author}";
                }
            }
            return "Book not found.";
        }
       public bool BorrowBook(string title , string author)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title.Contains(title) || books[i].Availbillity)
                {
                    books[i].Availbillity = false;
                    return true;
                }
            }
            return false;
        }

    }

    class Book
    {
        public string title;
        public string author;
        int ISBN;
       public  bool Availbillity;

        public Book(string title, string author, int iSBN, bool availbillity)
        {
            this.title = title;
            this.author = author;
            ISBN = iSBN;
            Availbillity = availbillity;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library(new List<Book>());
            Console.WriteLine(library.Addbook("The Great Gatsby", "F. Scott Fitzgerald", 123456789, true));
            Console.WriteLine(library.Addbook("To Kill a Mockingbird", "Harper Lee", 2458648, false));
            Console.WriteLine(library.Addbook("1984", "George Orwell", 305011337, true));

            Console.WriteLine("Searching and borrowing books...");

            Console.WriteLine(  library.BorrowBook("The Great Gatsby", "F. Scott Fitzgerald"));
            Console.WriteLine( library.BorrowBook("1984", "George Orwell"));
            Console.WriteLine(   library.BorrowBook("Harry Potter", "J.K. Rowling")); 
        }

    }
}
