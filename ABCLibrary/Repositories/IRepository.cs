using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCLibrary.Repositories
{
    public interface IBookRepository
    {
        Book Add(Book book);    
        Book Update(Book book);
        void Delete(Book book);

        Book Get(int id);
        Book GetByName(string name);
    }
}
