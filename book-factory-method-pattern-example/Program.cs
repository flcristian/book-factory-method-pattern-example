using book_factory_method_pattern_example.bookshelf;

internal class Program
{
    private static void Main(string[] args)
    {
        Bookshelf[] bookshelves = new Bookshelf[3];
        bookshelves[0] = new ActionBookshelf();
        bookshelves[1] = new ComedyBookshelf();
        bookshelves[2] = new RomanceBookshelf();

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine(bookshelves[i]);
        }
    }
}