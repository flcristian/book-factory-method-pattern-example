using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_factory_method_pattern_example.book
{
    public class ComedyBook : Book
    {
        public ComedyBook(String text) : base(text) { }

        public ComedyBook(String name, String author) : base(name, author) { }

        // Methods

        public override string ToString()
        {
            String desc = "Comedy Book\n";
            desc += $"Name : {Name}\n";
            desc += $"Author : {Author}\n";
            return desc;
        }
    }
}
