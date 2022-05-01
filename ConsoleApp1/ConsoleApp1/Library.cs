using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Library
    {
        public int Id { get; set; }

        public string Name { get; set; }

        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            if (book != null)
                books.Add(book);

        }
        public void ShowAllBooks()
        {
            foreach (Book item in books)
            {
                Console.WriteLine(item.Showinfo());
            }
        }

        public Book FindBookById(int id)
        {
            if (books.Exists(x => x.Id == id))
            {
                return books.Find(book => book.Id == id);
            }
            return null;
        }

        public Book FindBookByBookCode(string value)
        {

            if (books.Exists(x => x.BookCode == value))
            {
                return books.Find(book => book.BookCode == value);
            }
            return null;
        }
        public void RemuveBookById(int id)
        {
            if (books.Exists(book => book.Id == id))
            {
                Book want = books.Find(book => book.Id == id);
                books.Remove(want);
            }
        }
    }
}
