using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models

{

    public class Book

    {

        public int BookID { get; set; } // Primary Key 

        public string Title { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }

        public string Publisher { get; set; }

        public int Year { get; set; }

    }

}
