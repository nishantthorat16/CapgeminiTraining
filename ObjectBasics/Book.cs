using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectBasics
{
    public enum BookCategory
    {
       
        Novel = 1,
        Horror,
        Chrime_Thriller  = 10,
        Chidrens_Novel,
        Comics
    }

    class Book
    {
        //Default Constructor or Empty Constructor
        public Book()
        {
            Id = 10001;
        }

         //Parametarized Constructor
         public Book(int id) {
            Id = id;
         }

        //Methods Has Return Type, Construstors dont
        //Methods can have any name, Constructors shold
        //have class name
        public Book(int id, string serialNumber)
        {
            Id              = id;
            SerialNumber    = serialNumber;
        }

        //Destructors 
        //No parameter
        //Cannot be called directrly
        ~Book()
        {
            Console.WriteLine("Bye bye book");
        }

        //Auto implemented property are 
        //properties which does not have a explicit
        //backing field
        public int Id { get; private set; }

        public BookCategory Category { get; set; }

        string title; //Backing Field

        public string Title
        {
            get { return title; }
            set {
                    if (value.Length > 0)
                        title = value;
                    else
                        throw new Exception("Title Cannot be emptyy");
                }
        }

        public string Author { 
                get { return author; } 
                set { author = value; } 
        }

        public string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }

        string author;
        private string serialNumber;

        #region oldmethods
        //public void setAuthor(string t)
        //{
        //    if (t.Length > 0)
        //        Author = t;
        //    else
        //        throw new Exception("Author cannot be blank");
        //}

        //public string getAuthor()
        //{
        //    return Author;
        //}

        //public void setTitle(string t)
        //{
        //    if (t.Length > 0)
        //        Title = t;
        //    else
        //        throw new Exception("Title cannot be blank");
        //}

        //public string getTitle()
        //{
        //    return Title;
        //}

        #endregion
    }
}
