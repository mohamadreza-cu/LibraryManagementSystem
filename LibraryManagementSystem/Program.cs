using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); // Set MainForm as the startup form
        }
    }
}
