using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySample
{ 
    public interface IPremiumLibraryServices
    {
        void BuyBook(Book book);
    }

    public abstract class Member
    {
        public int Id        { get; protected set; }
        public string Name   { get; set; }
        public string Emaill { get; set; }
        public int MaxRentDays { get; protected set; }

        public virtual void Rent(Book book)
        {
            Console.WriteLine($"You have rented the book,{book.Title}");
        }
    }

    public class RegularMember : Member
    {
        public RegularMember()
        {
            MaxRentDays = 15;
        }
    }

    public class PremiumMember : Member, IPremiumLibraryServices
    {
        public PremiumMember()
        {
            MaxRentDays = 20;
        }

        public void BuyBook(Book book)
        {
            Console.WriteLine($"You have brought the book : {book.Title}");
        }
    }
}
