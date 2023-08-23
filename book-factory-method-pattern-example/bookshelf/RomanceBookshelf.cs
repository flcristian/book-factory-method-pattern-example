using book_factory_method_pattern_example.book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_factory_method_pattern_example.bookshelf
{
    public class RomanceBookshelf : Bookshelf
    {
        public RomanceBookshelf(List<Book> books) : base(books) { }

        public RomanceBookshelf(String text) : base()
        {
            String[] data = text.Split('/');

            IBookFactory bookFactory = new BookFactory();
            for (int i = 1; i < data.Length; i += 2)
            {
                Books.Add(bookFactory.CreateBook("romance", data[i], data[i + 1]));
            }
        }

        public RomanceBookshelf() { }

        // Methods

        public override string ToString()
        {
            String desc = "Romance Bookshelf\n=-=-=-=-=-=-=-=\n";
            foreach (Book book in Books)
            {
                desc += $"{book}\n";
            }
            return desc;
        }
    }
}
