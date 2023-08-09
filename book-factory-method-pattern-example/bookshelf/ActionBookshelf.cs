using book_factory_method_pattern_example.book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_factory_method_pattern_example.bookshelf
{
    public class ActionBookshelf : Bookshelf
    {
        public ActionBookshelf()
        {
            Books.Add(new ActionBook("name", "author"));
            Books.Add(new ActionBook("name", "author"));
            Books.Add(new ActionBook("name", "author"));
            Books.Add(new ActionBook("name", "author"));
        }
    }
}
