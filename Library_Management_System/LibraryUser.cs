using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class LibraryUser :User
    {
        public LibraryUser(string name)
        {
            Name = name;
        }
        LibraryCard card {  get; set; }
        public void borrowBook(Books BorroweBook ,Library library)
        {
            library.borrowBook(BorroweBook);
        }
    }
}
