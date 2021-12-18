using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AssignmentMichaelSingh
{
    class ReadDataFile
    {
        private BookDataStructure books = new BookDataStructure();

        public void readData()
        {
            StreamReader reader = new StreamReader("Books.txt");

            string line = "";
            while((line = reader.ReadLine()) != null)
            {
                string[] word = line.Split(',');
                Book bk = new Book();
                bk.Author = word[0];
                bk.BookName = word[1];
                bk.Publisher = word[2];
                bk.Year = int.Parse(word[3]);
                bk.Category = word[4];

                
                books.addBook(bk);
            }
        }

        public List<Book> getAllBooks()
        {
            return books.getAllBooks();
        }

       /* public void readBook(Book bk)
        {
            books.addBook(bk);
        }*/


        /*
        public Queue<Book> softwareDevelopmentCategory()
        {
            Queue<Book> data = new Queue<Book>();

            foreach (Book bk in books)
            {
                string category = bk.Category.ToLower();
                if (bk.Category.Equals("Programming"))
                {
                    data.Enqueue(bk);
                }
            }
            return data;
        }

        public Queue<Book> computerScienceCategory()
        {
            Queue<Book> data = new Queue<Book>();

            foreach (Book bk in books)
            {
                string category = bk.Category.ToLower();
                if (bk.Category.Equals("Computer Science"))
                {
                    data.Enqueue(bk);
                }
            }
            return data;
        }

        public Queue<Book> netowrkingCategory()
        {
            Queue<Book> data = new Queue<Book>();

            foreach (Book bk in books)
            {
                string category = bk.Category.ToLower();
                if (bk.Category.Equals("Networking"))
                {
                    data.Enqueue(bk);
                }
            }
            return data;
        }

        public Queue<Book> mathematicsCategory()
        {
            Queue<Book> data = new Queue<Book>();

            foreach (Book bk in books)
            {
                string category = bk.Category.ToLower();
                if (bk.Category.Equals("Mathematics"))
                {
                    data.Enqueue(bk);
                }
            }
            return data;
        }
        */


    }
}
