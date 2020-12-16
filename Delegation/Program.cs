using System;
using System.Collections.Generic;

namespace Delegation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>() {
            new Book{Title="Gullivers Travels", Price=10M, YearPublished= 1726 },
            new Book{Title="War and Peace", Price=20M, YearPublished= 1869 },
            new Book{Title="This is going to hurt", Price=5M, YearPublished= 2017 }
            };

            //List<Book> cheapBooks = FindCheapBooks(books);
            //List<Book> recentBooks = FindRecentBooks(books);
            //List<Book> cheapBooks = FindBooks(books, CheapBook);
            //List<Book> recentBooks = FindBooks(books, RecentBook);

            List<Book> cheapBooks = FindBooks(books, b => b.Price < 15M);
            List<Book> recentBooks = FindBooks(books, b => b.YearPublished > 2000);

        }
        static List<Book> FindBooks(List<Book> books, Func<Book, bool> func)
        {
            List<Book> output = new List<Book>();
            foreach (Book book in books)
            {
                if (func(book))
                {
                    output.Add(book);
                }
            }
            return output;
        }
        //static bool CheapBook(Book book)
        //{
        //    return book.Price < 15M;
        //}
        //static bool RecentBook(Book book)
        //{
        //    return book.YearPublished > 2000;
        //}

        //reptitive code
        //static List<Book> FindCheapBooks(List<Book> books)
        //{
        //    List<Book> output = new List<Book>();
        //    foreach (Book book in books)
        //    {
        //        if (book.Price < 15M)
        //        {
        //            output.Add(book);
        //        }
        //    }
        //    return output;
        //}

        //static List<Book> FindRecentBooks(List<Book> books)
        //{
        //    List<Book> output = new List<Book>();
        //    foreach (Book book in books)
        //    {
        //        if (book.YearPublished > 2000)
        //        {
        //            output.Add(book);
        //        }
        //    }
        //    return output;
        //}
    }
}
