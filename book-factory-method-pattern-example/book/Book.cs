using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_factory_method_pattern_example.book
{
    public abstract class Book
    {
        private String _name;
        private String _author;

        // Constructors

        public Book(String name, String author)
        {
            _name = name;
            _author = author;
        }

        // Accessors

        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public String Author
        {
            get { return _author; }
            set
            {
                _author = value;
            }
        }

        // Methods

        public override bool Equals(object? obj)
        {
            return (obj as Book)._name == _name && (obj as Book)._author == _author;
        }

        public override string ToString()
        {
            String desc = "";
            desc += $"Name : {_name}\n";
            desc += $"Author : {_author}\n";
            return desc;
        }
    }
}
