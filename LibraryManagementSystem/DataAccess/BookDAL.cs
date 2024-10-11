using System.Collections.Generic;

//using System.Data.SqlClient;
using MySql.Data.MySqlClient;

using LibraryManagementSystem.Models;



namespace LibraryManagementSystem.DataAccess

{

    public class BookDAL

    {

        private DatabaseHelper dbHelper = new DatabaseHelper();



        public void AddBook(Book book)

        {

            using (MySqlConnection conn = dbHelper.GetConnection())

            {

                string query = "INSERT INTO Book (Title, Author, ISBN, Publisher, Year) VALUES (@Title, @Author, @ISBN, @Publisher, @Year)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Title", book.Title);

                cmd.Parameters.AddWithValue("@Author", book.Author);

                cmd.Parameters.AddWithValue("@ISBN", book.ISBN);

                cmd.Parameters.AddWithValue("@Publisher", book.Publisher);

                cmd.Parameters.AddWithValue("@Year", book.Year);



                conn.Open();

                cmd.ExecuteNonQuery();

            }

        }



        public List<Book> GetBooks()

        {

            List<Book> books = new List<Book>();

            using (MySqlConnection conn = dbHelper.GetConnection())

            {

                string query = "SELECT * FROM Book";

                MySqlCommand cmd = new MySqlCommand(query, conn);



                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())

                {

                    books.Add(new Book

                    {

                        BookID = (int)reader["BookID"],

                        Title = reader["Title"].ToString(),

                        Author = reader["Author"].ToString(),

                        ISBN = reader["ISBN"].ToString(),

                        Publisher = reader["Publisher"].ToString(),

                        Year = (int)reader["Year"]

                    });

                }

            }

            return books;

        }



        // Implement UpdateBook and DeleteBook methods similarly 

    }

}