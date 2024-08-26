using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Librarian : User
    {
        int EmployeeNumber { get; set; }
 
        public Librarian(string name)
        {
            Name = name;
        }

        public void AddBooks(Books newBook)
        {

        }
        public void RemoveBooks(Books RemovedBook)
        {

        }

    }
}
