using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_WebAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }
    public class Repo
    {
        public static List<Book> Data;
        public Repo()
        {
            Data = new List<Book>();

            Data.Add(new Book { Id = 1, Name = "Book", Author = "Author", Year = 2002 });
            Data.Add(new Book { Id = 2, Name = "Book", Author = "Author", Year = 2000 });
            Data.Add(new Book { Id = 3, Name = "Book", Author = "Author", Year = 1998 });
            Data.Add(new Book { Id = 4, Name = "Book", Author = "Author", Year = 2009 });
        }
    }
}