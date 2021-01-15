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
            DialogResult resultLogin;
            User user;

            IAlbumRepository albumRepo = new AlbumRepository();
            IUserRepository userRepo = new UserRepository();

            using (var loginForm = new LoginForm(userRepo))
            {
                resultLogin = loginForm.ShowDialog();
                user = loginForm.User;
            }

            if (resultLogin == DialogResult.OK)
            {
                //User = user;
                //Application.Run(new MainForm(user,albumRepo,userRepo));
                
                using (var mainForm = new MainForm(user, albumRepo, userRepo))
                {
                    result = mainForm.ShowDialog();
                }
                while (result ==DialogResult.Retry)
                {
                    using (var loginForm = new LoginForm(userRepo))
                    {
                        resultLogin = loginForm.ShowDialog();
                        user = loginForm.User;
                    }
                    using (var mainForm = new MainForm(user, albumRepo, userRepo))
                    {
                        result = mainForm.ShowDialog();
                    }
                }
            }
            // Admin Profile, décommentez les trois lignes ci-dessous et commentez les lignes ci-dessus à partir de "using" ci-dessus
            //user = userRepo.GetUser("mdevreese@ensc.fr",
            //    "f4f263e439cf40925e6a412387a9472a6773c2580212a4fb50d224d3a817de17");
            //Application.Run(new MainForm(user, albumRepo, userRepo));

            // User Profile, décommentez la ligne ci-dessous et commentez les lignes ci-dessus à partir de "using" ci-dessus
            // Application.Run(new MainForm(userRepo.GetUser("toto@lambada.com", "f4f263e439cf40925e6a412387a9472a6773c2580212a4fb50d224d3a817de17"), albumRepo, userRepo));
        }
    }
}
