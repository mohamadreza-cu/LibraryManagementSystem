using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace LibraryManagementSystem.DataAccess

{

    public class DatabaseHelper

    {

        //private readonly string connectionString = "Data Source=your_server;Initial Catalog=LibraryDB;Integrated Security=True";
        private readonly string connectionString = "Server=database-1.cneppmybrm9m.us-east-1.rds.amazonaws.com;Database=library;User ID=admin;Password=adminadmin;";


        public MySqlConnection GetConnection()

        {

            return new MySqlConnection(connectionString);

        }

    }

}