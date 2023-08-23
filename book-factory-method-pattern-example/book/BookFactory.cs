using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace book_factory_method_pattern_example.book
{
    public class BookFactory : IBookFactory
    {
        public Book CreateBook(String text)
        {
            switch (text.Split('/')[0].ToLower())
            {
                case "action":
                    return new ActionBook(text);
                case "comedy":
                    return new ComedyBook(text);
                case "romance":
                    return new RomanceBook(text);
                default:
                    return new Book(text);
            }
        }

        public Book CreateBook(String type, String name, String author)
        {
            switch (type.ToLower())
            {
                case "action":
                    return new ActionBook(name, author);
                case "comedy":
                    return new ComedyBook(name, author);
                case "romance":
                    return new RomanceBook(name, author);
                default:
                    return new Book(name, author);
            }
        }
    }
}
