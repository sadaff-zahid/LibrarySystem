using System;
using System.Windows.Forms;

namespace LibrarySystem
{
    /// <summary>
    /// Entry point of the Library Management System application.
    /// </summary>
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Start with Login form
            Application.Run(new LoginForm());
        }
    }
}
