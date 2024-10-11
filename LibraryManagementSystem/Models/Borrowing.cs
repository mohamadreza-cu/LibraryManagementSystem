using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models

{

    public class Borrowing

    {

        public int BorrowingID { get; set; } // Primary Key 

        public int BookID { get; set; }      // Foreign Key 

        public int MemberID { get; set; }    // Foreign Key 

        public DateTime BorrowDate { get; set; }

        public DateTime? ReturnDate { get; set; } // Nullable 

    }

}