using System.Collections.Generic;

using LibraryManagementSystem.DataAccess;

using LibraryManagementSystem.Models;



namespace LibraryManagementSystem.BusinessLogic

{

    public class BookBLL

    {

        private BookDAL bookDAL = new BookDAL();



        public void AddBook(Book book)

        {

            // Validations 

            if (string.IsNullOrEmpty(book.Title) || string.IsNullOrEmpty(book.Author))

            {

                throw new ArgumentException("Title and Author are required.");

            }



            bookDAL.AddBook(book);

        }



        public List<Book> GetBooks()

        {

            return bookDAL.GetBooks();

        }



        // Implement UpdateBook and DeleteBook methods with business rules 

    }

}