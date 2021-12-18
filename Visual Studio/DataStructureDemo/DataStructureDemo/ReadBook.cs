using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    class ReadBook
    {
        private BookDataStructure books;

        public List<Book> readBooks()
        {
            return books.getAllBooks();
        }

        public ReadBook()
        {
            books = new BookDataStructure();
        }

        public void readBook(Book bk)
        {
            books.addBook(bk);
        }

        public Book searchBookById(int id)
        {
            return books.searchById(id);
        }

        public Book searchByTitle(string title)
        {
            return books.searchByTitle(title);
        }
    }
}
