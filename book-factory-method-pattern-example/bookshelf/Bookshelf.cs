using book_factory_method_pattern_example.book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_factory_method_pattern_example.bookshelf
{
    public abstract class Bookshelf
    {
        private List<Book> _books;

        // Constructors

        public Bookshelf()
        {
            _books = new List<Book>();
        }

        // Accessors

        public List<Book> Books
        {
            get { return _books; }
            set
            {
                _books = value;
            }
        }

        // Methods

        public override bool Equals(object? obj)
        {
            return (obj as Bookshelf)._books == _books;
        }

        public override string ToString()
        {
            String desc = "Shelf\n=-=-=-=-=-=-=-=\n";
            foreach(Book book in _books)
            {
                desc += $"{book}\n";
            }
            return desc;
        }
    }
}
