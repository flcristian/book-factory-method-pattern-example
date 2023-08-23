using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_factory_method_pattern_example.book
{
    public class RomanceBook : Book
    {
        public RomanceBook(String text) : base(text) { }

        public RomanceBook(String name, String author) : base(name, author) { }

        // Methods

        public override string ToString()
        {
            String desc = "Romance Book\n";
            desc += $"Name : {Name}\n";
            desc += $"Author : {Author}\n";
            return desc;
        }
    }
}
