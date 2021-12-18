using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    class ProcessBook
    {
        List<Book> availableBooks = new List<Book>();
        List<Book> notAvailableBooks = new List<Book>();

        public void processBook(ReadBook readBook)
        {
            List<Book> books = readBook.readBooks();
            foreach(Book bk in books)
            {
                if (bk.Status.Equals("Available"))
                {
                    availableBooks.Add(bk);
                }
                else
                {
                    notAvailableBooks.Add(bk);
                }
            }
        }
    }
}
