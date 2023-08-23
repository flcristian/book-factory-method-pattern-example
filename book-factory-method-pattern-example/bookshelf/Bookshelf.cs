using book_factory_method_pattern_example.book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_factory_method_pattern_example.bookshelf
{
    public class Bookshelf
    {
        private List<Book> _books;

        // Constructors

        public Bookshelf(List<Book> books)
        {
            _books = books;
        }
        
        public Bookshelf(String text)
        {
            _books = new List<Book>();

            String[] data = text.Split('/');
            
            IBookFactory bookFactory = new BookFactory();
            for(int i = 1; i < data.Length; i += 3)
            {
                _books.Add(bookFactory.CreateBook(data[i], data[i + 1], data[i + 2]));
            }
        }

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
            String desc = "Bookshelf\n=-=-=-=-=-=-=-=\n";
            foreach(Book book in _books)
            {
                desc += $"{book}\n";
            }
            return desc;
        }
    }
}
