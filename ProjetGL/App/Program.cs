using System;
using System.Windows.Forms;
using DAL;

namespace App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IUserRepository userRepo = new UserRepository();
            Application.Run(new LoginForm(userRepo));
        }
    }
}
