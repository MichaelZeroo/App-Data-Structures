using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMichaelSingh
{
    class Book
    {
        public string Author { get; set; }
        public string BookName { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public string Category { get; set; }


        public override string ToString()
        {
            return "Author: " + Author + ", Book Name: " + BookName + ", Publisher: " + Publisher + ", Year: " + Year + ", Category: " + Category;
        }
    }
}
