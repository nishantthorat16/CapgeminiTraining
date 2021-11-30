using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingDataThroughParameters
{
    public class Book
    {
        public int Id           { get; set; }
        public string Title     { get; set; }
        public string Author    { get; set; }
    }

    public class Library{
        static List<Book> books = new List<Book>();
        public Library(){
            if (books.Count == 0)
            {
                books.Add(new Book { Id = 1, Title = "Angels and Demons", Author = "Dan Brown" });
                books.Add(new Book { Id = 2, Title = "Harry Potter", Author = "JK Roling" });
                books.Add(new Book { Id = 3, Title = "Dracula", Author = "Bram Stroker" });
                books.Add(new Book { Id = 4, Title = "Sherlock Holmes", Author = "Arthur" });
                books.Add(new Book { Id = 5, Title = "Davinci Code", Author = "Dan Brown" });
            }
        }
        public List<Book> GetBooks()
        {
            return books;
        }
        public Book FindBookById(int id){
            Book book = null;
            foreach(var b in books){
                if (b.Id == id) {
                    book = b;
                    break;
                }
            }
            return book;
        }
    }
}
