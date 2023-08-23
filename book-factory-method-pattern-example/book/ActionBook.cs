using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace book_factory_method_pattern_example.book
{
    public class ActionBook : Book
    {
        public ActionBook(String text) : base(text) { }

        public ActionBook(String name, String author) : base(name, author) { }

        // Methods

        public override string ToString()
        {
            String desc = "Action Book\n";
            desc += $"Name : {Name}\n";
            desc += $"Author : {Author}\n";
            return desc;
        }
    }
}
