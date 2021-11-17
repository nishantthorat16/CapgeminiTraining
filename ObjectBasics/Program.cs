using System;

namespace ObjectBasics
{
    /*
        1. public // Public members are those who can be accessed by any class
        2. private // Can only be accessed with in the same class
        3. internal //Visible as public inside the same assembly/project
                    //Hidden for other projects 
        4. protected
        5. protected internal
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] bookArray     = new Book[3];
            #region oldcode
            /*
            Book book1           = new Book();
            book1.Title          = "Angels and Demons";
            book1.Category       = BookCategory.Chrime_Thriller;
            book1.Author         = "Dan Brown";
            book1.SerialNumber   = "12345";

            Book book2          = new Book();
            book2.Title         = "Harry Potter";
            book2.Author        = "JK Rowling";
            book2.Category      = BookCategory.Novel;
            book2.SerialNumber  = "456789";

            Book book3          = new Book();
            book3.Title         = "Harry Potter";
            book3.Author        = "JK Rowling";
            book3.Category      = BookCategory.Novel;
            book3.SerialNumber  = "456789";

            BookCategory category = (BookCategory)Enum.Parse(typeof(BookCategory)
                                                 ,Console.ReadLine());

            bookArray[0] = book1;
            bookArray[1] = book2;*/

            #endregion

            for(int i=0;i<3;i++)
            {
                Book book = new Book();

                Console.Write("Title : ");
                book.Title = Console.ReadLine();

                Console.Write("Author : ");
                book.Author = Console.ReadLine();

                Console.Write("Category : ");
                book.Category = (BookCategory)Enum.Parse(typeof(BookCategory),Console.ReadLine());

                bookArray[i] = book;
                Console.WriteLine("-----------------------------------------------------");
            }

            Console.WriteLine("\n\n------------------------------------------------------------\n\n");
            foreach (Book book in bookArray)
                Console.WriteLine($"{book.Title}   {book.Author}   {book.Category}");

            Console.WriteLine("\n\n------------------------------------------------------------\n\n");

            var userInput = "";
            do
            {
                Console.WriteLine("Enter the category you want to search (Type 'Exit' to quit) :");
                userInput = Console.ReadLine();

                if (userInput != "Exit")
                {
                    var category = (BookCategory)Enum.Parse(typeof(BookCategory), userInput);

                    foreach (var book in bookArray)
                    {
                        if (book.Category == category)
                            Console.WriteLine($"{book.Title}   {book.Author}   {book.Category}");
                    }
                }
            }
            while (userInput != "Exit");

        }
    }
}
