using System;
using System.Windows.Forms;
using DAL;
using DAL.Repositories;
using DAL.Services;
using Domain;

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

            //DialogResult result;
            //User user;
            
            IUserRepository userRepo = new UserRepository();
            //using (var loginForm = new LoginForm(userRepo))
            //{
            //    result = loginForm.ShowDialog();
            //    user = loginForm.User;
            //}

            //if (result == DialogResult.OK)
            //{
            //    Application.Run(new Mainform(user));
            //}

            Application.Run(new MainForm(userRepo.GetUser("mdevreese@ensc.fr", "f4f263e439cf40925e6a412387a9472a6773c2580212a4fb50d224d3a817de17")));
        }
    }
}
