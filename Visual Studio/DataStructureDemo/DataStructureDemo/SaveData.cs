using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    class SaveData
    {
        List<Book> availableBook = new List<Book>();
        List<Book> notAvailableBook = new List<Book>();


        public void save()
        {
            using (var ctx = new database)
            {
                
            }
        }
    }
}
