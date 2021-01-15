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

            DialogResult result;
            User user;

            IAlbumRepository albumRepo = new AlbumRepository();
            IUserRepository userRepo = new UserRepository();

            using (var loginForm = new LoginForm(userRepo))
            {
                result = loginForm.ShowDialog();
                user = loginForm.User;
            }

            if (result == DialogResult.OK)
            {
                //User = user;
                Application.Run(new MainForm(user,albumRepo,userRepo));
            }

            // Admin Profile, décommentez les trois lignes ci-dessous et commentez les lignes à partir de "using" ci-dessus
            //user = userRepo.GetUser("mdevreese@ensc.fr",
            //    "f4f263e439cf40925e6a412387a9472a6773c2580212a4fb50d224d3a817de17");
            //Application.Run(new MainForm(user, albumRepo, userRepo));

            // User Profile, décommentez la ligne ci-dessous et commentez les lignes à partir de "using" ci-dessus
            // Application.Run(new MainForm(userRepo.GetUser("toto@lambada.com", "f4f263e439cf40925e6a412387a9472a6773c2580212a4fb50d224d3a817de17"), albumRepo, userRepo));
        }
    }
}
