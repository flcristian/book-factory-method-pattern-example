using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_factory_method_pattern_example.book
{
    public class ComedyBook : Book
    {
        public ComedyBook(String name, String author) : base(name, author) { }
    }
}
