using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentMichaelSingh.Model;

namespace AssignmentMichaelSingh
{
    class SaveData
    {
        List<Book> computerScience = new List<Book>();
        List<Book> mathematics = new List<Book>();
        List<Book> networking = new List<Book>();
        List<Book> softwareDevelopment = new List<Book>();

        public void save()
        {
            using(var ctx = new GSQ4_Michael_ADSContext())
            {
                foreach (Book bk in computerScience)
                {
                    Model.Book b = new Model.Book();
                    b.Author = bk.Author;
                    b.BookName = bk.BookName;
                    b.Publisher = bk.Publisher;
                    b.Year = bk.Year;

                    Model.Category c = new Model.Category();
                    c.Category1 = bk.Category;

                    b.CategoryNavigation = c;

                    ctx.Book.Add(b);
                }
                foreach (Book bk in mathematics)
                {
                    Model.Book b = new Model.Book();
                    b.Author = bk.Author;
                    b.BookName = bk.BookName;
                    b.Publisher = bk.Publisher;
                    b.Year = bk.Year;

                    Model.Category c = new Model.Category();
                    c.Category1 = bk.Category;

                    b.CategoryNavigation = c;

                    ctx.Book.Add(b);
                }
                foreach (Book bk in softwareDevelopment)
                {
                    Model.Book b = new Model.Book();
                    b.Author = bk.Author;
                    b.BookName = bk.BookName;
                    b.Publisher = bk.Publisher;
                    b.Year = bk.Year;

                    Model.Category c = new Model.Category();
                    c.Category1 = bk.Category;

                    b.CategoryNavigation = c;

                    ctx.Book.Add(b);
                }
                foreach (Book bk in networking)
                {
                    Model.Book b = new Model.Book();
                    b.Author = bk.Author;
                    b.BookName = bk.BookName;
                    b.Publisher = bk.Publisher;
                    b.Year = bk.Year;

                    Model.Category c = new Model.Category();
                    c.Category1 = bk.Category;

                    b.CategoryNavigation = c;

                    ctx.Book.Add(b);
                }
                ctx.SaveChanges();
            }
        }
    }
}
