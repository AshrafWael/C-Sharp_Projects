using System.ComponentModel;
using System.Diagnostics;

namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcom to the library System");
            Library library = new Library();
            Console.WriteLine("Are you Librerian OR Regular User(L/R)");

            // char  result = Convert.ToChar(Console.ReadLine());
            char result = Console.ReadLine().ToUpper()[0];
            switch (result)
            {
                case 'L':
                    {
                        Console.WriteLine("welcom Libririan Enter your Name");
                        string libririanName = Console.ReadLine();
                        Librarian l1 = new Librarian(libririanName);
                        Console.WriteLine($"Welcom-{l1.Name}");

                        Console.WriteLine("please choose Add(A) OR Remove(R) OR Display(D)");
                        char Choice = Console.ReadLine().ToUpper()[0];

                        switch (Choice)
                        {
                            case 'A':
                                {
                                    Console.WriteLine("Enter Book Details");
                                    Console.WriteLine("Enter Book Name");
                                    string BookName = Console.ReadLine();
                                    Console.WriteLine("Enter BookAuthor");
                                    string BookAuthor = Console.ReadLine();
                                    Console.WriteLine("Enter Book publication Date");
                                    DateTime publishDate =Convert.ToDateTime(Console.ReadLine());
                                    // Books books = new Books(BookName, BookAuthor, publishDate);
                                    Books book1 = new Books()
                                    {
                                        Title = BookName,
                                        Author = BookAuthor,
                                        PublicationDate = publishDate
                                    };
                                    library.AddBooks(book1);
                                }
                                break;
                            case 'R':
                                { }
                                break;
                            case 'D':
                                { }
                                break;
                            default:
                                { }
                                break;
                        }

                    }break;
                case 'R':
                  { }
                  break;
                 default:
                 {
                     Console.WriteLine("please enter just L OR R");
                 } break;

            }
        }
    }
}
    