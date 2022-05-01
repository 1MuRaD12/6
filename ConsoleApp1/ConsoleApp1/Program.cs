using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("murad","mm","ap");
            Book book1 = new Book("murad","mm","ap");
            Book book2 = new Book("murad","mm","ap");
            Book book3 = new Book("murad","mm","ap");
            Book book4 = new Book("murad","mm","ap");

            Library library = new Library();
            library.AddBook(book);

            Console.WriteLine("book");
            library.ShowAllBooks();
            Console.WriteLine("find by id");
            Console.WriteLine(library.FindBookById(1).Showinfo());
            Console.WriteLine("find book by bookcode");
            Console.WriteLine(library.FindBookByBookCode("s").Showinfo());

            Console.WriteLine("book list agen");
            library.ShowAllBooks();

            library.RemuveBookById(1);
            Console.WriteLine("after delete");
            library.ShowAllBooks();

            library.AddBook(book4);
            Console.WriteLine("after delete");
            library.ShowAllBooks();
        }
    }
}
