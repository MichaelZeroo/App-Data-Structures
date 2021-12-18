using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    class BookDataStructure
    {
        private Dictionary<string, Book> books;


        public List<Book> getAllBooks()
        {
            return books.Values.ToList();
        }
        
        public BookDataStructure()
        {
            books = new Dictionary<string, Book>();
        }

        public void addBook(Book book)
        {
            books.Add(book.Title, book);
        }




        public Book searchByTitle(string title)
        {
            return books[title];
        }

        public Book searchById(int bid)
        {
            Book found = null;
            foreach(Book bk in books.Values)
            {
                if(bk.ID == bid)
                {
                    found = bk;
                    break;
                }
            }
            return found;
        }
    }
}
