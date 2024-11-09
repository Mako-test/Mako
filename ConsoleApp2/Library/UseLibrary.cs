
namespace Library
{
    internal class UseLibrary
    {
        static void Main()
        {
            Library library = new Library();

            library.AddBook(new book("Selected Short Stories", "E.A Poe", 2020));
            library.AddBook(new book("At the mountains of Madness", "H.P. Lovecraft", 1936));
            library.AddBook(new book("Pride And Prejudice", "Jane Austin", 1813));


            Console.WriteLine("Books in the library");
            library.PrintBooks();

            Console.WriteLine($"\n Amount of Books in Library: {library.Count}");

            Console.WriteLine("\n Search 'Selected Short Stories':");

            var foundBooks = library.FindBook("Selected Short Stories");
            foreach (var book in foundBooks)
            {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine("\n Delete Book 'Selected Short Stories' :");
            library.RemoveBook("At the mountains of Madness");

            Console.WriteLine("\n Books left in library");
            library.PrintBooks();
        }
    }
}

