using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_factory_method_pattern_example.book
{
    public interface IBookFactory
    {
        Book CreateBook(String text);

        Book CreateBook(String type, String name, String author);
    }
}
