using book_factory_method_pattern_example.book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace book_factory_method_pattern_example.bookshelf
{
    public class BookshelfFactory : IBookshelfFactory
    {
        public Bookshelf CreateBookshelf(String type,List<Book> books)
        {
            switch (type.ToLower())
            {
                case "action":
                    return new ActionBookshelf(books);
                case "comedy":
                    return new ComedyBookshelf(books);
                case "romance":
                    return new RomanceBookshelf(books);
                default:
                    return new Bookshelf(books);
            }
        }

        public Bookshelf CreateBookshelf(String text)
        {
            switch (text.Split('/')[0].ToLower())
            {
                case "action":
                    return new ActionBookshelf(text);
                case "comedy":
                    return new ComedyBookshelf(text);
                case "romance":
                    return new RomanceBookshelf(text);
                default:
                    return new Bookshelf(text);
            }
        }

        public Bookshelf CreateBookshelf()
        {
            return new Bookshelf();
        }
    }
}
