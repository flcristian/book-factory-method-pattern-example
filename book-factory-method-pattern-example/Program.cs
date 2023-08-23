using book_factory_method_pattern_example.book;
using book_factory_method_pattern_example.bookshelf;

internal class Program
{
    private static void Main(string[] args)
    {
        IBookshelfFactory bookshelfFactory = new BookshelfFactory();
        IBookFactory bookFactory = new BookFactory();
        Bookshelf[] bookshelves = new Bookshelf[3];
        bookshelves[0] = bookshelfFactory.CreateBookshelf("base", new List<Book> { bookFactory.CreateBook("action", "name", "author"), bookFactory.CreateBook("romance", "name", "author") });
        bookshelves[1] = bookshelfFactory.CreateBookshelf("action/name/author/name/author/name/author");
        bookshelves[2] = bookshelfFactory.CreateBookshelf("base/romance/name/author/comedy/name/author");

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine(bookshelves[i]);
        }
    }
}