using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AssignmentMichaelSingh
{
    class BookDataStructure
    {
        private Queue<Book> books;

        public List<Book> getAllBooks()
        {
            List<Book> bk = new List<Book>();
            foreach(Book book in books)
            {
                books.Dequeue();
                bk.Add(book);
            }
            return bk;
        }

        public BookDataStructure()
        {
            books = new Queue<Book>();
        }

        public void addBook(Book book)
        {
            books.Enqueue(book);
        }
    }
}
