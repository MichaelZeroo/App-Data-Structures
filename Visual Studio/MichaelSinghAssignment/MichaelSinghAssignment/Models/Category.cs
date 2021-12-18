using System;
using System.Collections.Generic;

namespace MichaelSinghAssignment.Models
{
    public partial class Category
    {
        public Category()
        {
            Book = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Category1 { get; set; }

        public ICollection<Book> Book { get; set; }
    }
}
