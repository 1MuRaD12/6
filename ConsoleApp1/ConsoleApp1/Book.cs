using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Book
    {
        public int Id { get; }

        public static int Count = 0;

        public string Name { get; set; }

        public string AuthorName { get; set; }

        public string BookCode { get; set; }

        public Book(string name, string authorname, string bookcode)
        {
            Id =  ++Count;
            Name = name;
            AuthorName = authorname;
            
            BookCode = bookcode.Substring(1).ToUpper() + (1000 + Id);
        }
        public string Showinfo()
        {
            return $"Name:{Name}\nAuthorName:{AuthorName}\nBookCode:{BookCode}\nId:{Id}";
        }
    }
}
