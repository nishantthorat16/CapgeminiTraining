using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ABCLibrary.Repositories
{
    public class BookRepository : IBookRepository
    {
        LibraryDbContext dbContext;

        public BookRepository(LibraryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Book Add(Book book)
        {
            if (!Regex.IsMatch(book.Title, "^[a-zA-Z ]*$"))
                throw new ValidationException("Invalid Book Title");

            dbContext.Books.Add(book);
            dbContext.SaveChanges();

            return book;
        }

        public void Delete(Book book)
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            throw new NotImplementedException();
        }

        public Book GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Book Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
