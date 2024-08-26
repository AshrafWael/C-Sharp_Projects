using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Library
    {
        private  Books[] Book = new Books[200];
 private int  currrentBookCount = 0;
        private  Books[] BorrowedBooks= new Books[50];
        private int currrentBorrowedBookCount = 0;


        public void AddBooks(Books newBook)
        {
            if (currrentBookCount < Book.Length)
            {
                Book[currrentBookCount] = newBook;
                currrentBookCount++;
                Console.WriteLine("Book Added Sucsesfuly");
            }
            else
            {
                Console.WriteLine("Library is full Can not add new Books");
            }

        }
        public void RemoveBooks(Books RemovedBook)
        {
            if (currrentBookCount < Book.Length)
            {
                int index = Array.IndexOf(Book, RemovedBook);
                Book[index] = null;
                currrentBookCount--;
                Console.WriteLine("Book Removed");
            }
            else
            {
                Console.WriteLine("Library is empty Can not add new Books");
            }

        }
        public void DisplayBooks()
        {
            foreach (var item in Book)
            {
                Console.WriteLine($"Title -{item.Title} Author- {item.Author}");
            }

        }
    }
}
