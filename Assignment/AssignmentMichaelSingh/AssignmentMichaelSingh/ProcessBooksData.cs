using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMichaelSingh
{
    class ProcessBooksData
    {
        List<Book> computerScience = new List<Book>();
        List<Book> mathematics = new List<Book>();
        List<Book> networking = new List<Book>();
        List<Book> softwareDevelopment = new List<Book>();

        public List<Book> computerScienceCategory()
        {
            ReadDataFile readDataFile = new ReadDataFile();
            List<Book> books = readDataFile.getAllBooks();

            foreach (Book bk in books)
            {
                string category = bk.Category.ToLower();
                if (bk.Category.Equals("Computer Science"))
                {
                    computerScience.Add(bk);
                }
            }
            return books;
        }

        public List<Book> softwareDevelopmentCategory()
        {
            ReadDataFile readDataFile = new ReadDataFile();
            List<Book> books = readDataFile.getAllBooks();

            foreach (Book bk in books)
            {
                string category = bk.Category.ToLower();
                if (bk.Category.Equals("Programming"))
                {
                    softwareDevelopment.Add(bk);
                }
            }
            return books;
        }

        public List<Book> mathematicsCategory()
        {
            ReadDataFile readDataFile = new ReadDataFile();
            List<Book> books = readDataFile.getAllBooks();

            foreach (Book bk in books)
            {
                string category = bk.Category.ToLower();
                if (bk.Category.Equals("Mathematics"))
                {
                    mathematics.Add(bk);
                }
            }
            return books;
        }

        public List<Book> networkingCategory()
        {
            ReadDataFile readDataFile = new ReadDataFile();
            List<Book> books = readDataFile.getAllBooks();

            foreach (Book bk in books)
            {
                string category = bk.Category.ToLower();
                if (bk.Category.Equals("Networking"))
                {
                    networking.Add(bk);
                }
            }
            return books;
        }
    }
}
