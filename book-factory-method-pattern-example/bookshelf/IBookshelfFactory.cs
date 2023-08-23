using book_factory_method_pattern_example.book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_factory_method_pattern_example.bookshelf
{
    public interface IBookshelfFactory
    {
        Bookshelf CreateBookshelf(String type, List<Book> books);

        Bookshelf CreateBookshelf(String text);

        Bookshelf CreateBookshelf();
    }
}
