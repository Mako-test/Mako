
namespace Library {
    public class book
{
    public string Title {get; set;}
    public string Author {get; set;}
    public int Year {get; set;}

    public book (string title, string author, int year)

        {
            Title = title;
            Author = author;
            Year = year;
        }
}
    public class Library
    {
        private List<book> books;

        public Library()
        {
            books = new List<book>();
        }

        public int Count => books.Count;
        public void AddBook (book book)
            { 
            books.Add(book);
        }
        public void RemoveBook(string title)
        {
            var deleteBook = books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (deleteBook != null)
            {
                books.Remove(deleteBook);
                Console.WriteLine($"Book '{title}' has been successfully deleted");
            }
            else
            {
                Console.WriteLine($"Book '{title}' couldn't be found");
            }


        }
        public List<book> FindBook(string title)
        {
            return books.FindAll(book => book.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
        }

        public void PrintBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Librery Is empty");
            }
            else
            {
                //Console.WriteLine("Books in the library:");
                foreach (var book in books)
                {
                    Console.WriteLine(book.Title);
                }
            }
        }

    }
   

}
