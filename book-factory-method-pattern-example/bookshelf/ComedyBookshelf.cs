using book_factory_method_pattern_example.book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_factory_method_pattern_example.bookshelf
{
    public class ComedyBookshelf : Bookshelf
    {
        public ComedyBookshelf(List<Book> books) : base(books) { }

        public ComedyBookshelf(String text) : base()
        {
            String[] data = text.Split('/');

            IBookFactory bookFactory = new BookFactory();
            for (int i = 1; i < data.Length; i += 2)
            {
                Books.Add(bookFactory.CreateBook("comedy", data[i], data[i + 1]));
            }
        }

        public ComedyBookshelf() { }

        // Methods

        public override string ToString()
        {
            String desc = "Comedy Bookshelf\n=-=-=-=-=-=-=-=\n";
            foreach (Book book in Books)
            {
                desc += $"{book}\n";
            }
            return desc;
        }
    }
}
