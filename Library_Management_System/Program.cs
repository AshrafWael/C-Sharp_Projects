﻿using System.ComponentModel;
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
                        while (true)
                        {
                            Console.WriteLine("please choose Add(A) OR Remove(R) OR Display(D)");
                            char Choice = Console.ReadLine().ToUpper()[0];

                            switch (Choice)
                            {
                                case 'A':
                                    {
                                        Console.WriteLine("Enter Book Details To Add");
                                        Console.WriteLine("Enter Book Name");
                                        string BookName = Console.ReadLine();
                                        Console.WriteLine("Enter BookAuthor");
                                        string BookAuthor = Console.ReadLine();
                                        Console.WriteLine("Enter Book publication Date");
                                        int publishDate = Convert.ToInt32(Console.ReadLine());
                                        // Books books = new Books(BookName, BookAuthor, publishDate);
                                        Books book1 = new Books()
                                        {
                                            Title = BookName,
                                            Author = BookAuthor,
                                            PublicationDate = publishDate
                                        };
                                        //add book to library from libririan (separation of ) 
                                        l1.AddBooks(book1, library);
                                    }
                                    break;
                                case 'R':
                                    {
                                        Console.WriteLine("Enter Book Details To Remove");
                                        Console.WriteLine("Enter Book Name");
                                        string BookName = Console.ReadLine();
                                        Console.WriteLine("Enter BookAuthor");
                                        string BookAuthor = Console.ReadLine();
                                        Console.WriteLine("Enter Book publication Date");
                                        int publishDate = Convert.ToInt32(Console.ReadLine());
                                        // Books books = new Books(BookName, BookAuthor, publishDate);
                                        Books book1 = new Books()
                                        {
                                            Title = BookName,
                                            Author = BookAuthor,
                                            PublicationDate = publishDate
                                        };
                                        //add book to library from libririan (separation of ) 
                                        l1.RemoveBooks(book1, library);
                                    } 
                                    break;
                                case 'D':
                                    {
                                        l1.DisplayBooks(library);
                                    } 
                                    break;
                                default:
                                    {
                                        Environment.Exit(0);
                                    }
                                    break;
                            }

                        }       
                    }
                    break;
                    case 'R':
                    {
                        Console.WriteLine("welcom user Enter your Name");
                        string usereame = Console.ReadLine();
                        LibraryUser user1 = new LibraryUser(usereame);
                        Console.WriteLine($"Welcom-{user1.Name}");
                     while (true) 
                     { 
                        Console.WriteLine("please choose Borrow(B) OR Display(D)");
                        char Choice = Console.ReadLine().ToUpper()[0];

                        switch (Choice)
                        {
                            case 'B':
                                {
                                    Console.WriteLine("Enter Book Details You Want To Borrow");
                                    Console.WriteLine("Enter Book Name");
                                    string BookName = Console.ReadLine();
                                    Console.WriteLine("Enter BookAuthor");
                                    string BookAuthor = Console.ReadLine();
                                    // Books books = new Books(BookName, BookAuthor, publishDate);
                                    Books BORRO = new Books()
                                    {
                                        Title = BookName,
                                        Author = BookAuthor
                                    };
                                    user1.borrowBook(BORRO, library);
                                }
                                break;
                            case 'D':
                                {
                                    user1.DisplayBooks(library);
                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("please enter just B OR D");
                                }
                                break;
                        }
                     }
                    }
                        break;
                    default:
                        {
                            Console.WriteLine("please enter just L OR R");
                        }
                        break;
                }
            

            }
        }
    }

    