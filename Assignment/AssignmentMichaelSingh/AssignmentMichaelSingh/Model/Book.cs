using System;
using System.Collections.Generic;

namespace AssignmentMichaelSingh.Model
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string BookName { get; set; }
        public string Publisher { get; set; }
        public int? Year { get; set; }
        public int Category { get; set; }

        public Category CategoryNavigation { get; set; }
    }
}
