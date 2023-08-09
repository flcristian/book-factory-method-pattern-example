using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_factory_method_pattern_example.book
{
    public class RomanceBook : Book
    {
        public RomanceBook(String name, String author) : base(name, author) { }
    }
}
