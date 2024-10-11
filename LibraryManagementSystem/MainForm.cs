using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibraryManagementSystem.Presentation;
namespace LibraryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.Show(); // Opens as a non-modal window
            // Alternatively, use bookForm.ShowDialog(); to open as a modal window
        }

        private void btnManageBorrowing_Click(object sender, EventArgs e)
        {
            
            //BorrowingForm borrowingForm = new BorrowingForm();
            //borrowingForm.Show();

        }

        private void btnManageMembers_Click(object sender, EventArgs e)
        {
            //MemberForm memberForm = new MemberForm();
            //memberForm.Show();
        }


    }
}
