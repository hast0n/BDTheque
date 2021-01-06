using DAL.Services;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    public partial class LoginForm : Form
    {
        private readonly IUserRepository _userRepository;
        public User User { get; set; }

        public LoginForm(IUserRepository userRepo)
        {
            InitializeComponent();
            _userRepository = userRepo;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim().ToLower();
            string pswHash = SHA256Crypto.GetHash(passwordTextBox.Text);

            var result = _userRepository.GetUser(username, pswHash);

            if (result != null)
            {
                User = result;
                this.DialogResult = DialogResult.OK;
            }
            else PromptWrongCredentials();
        }

        private void PromptWrongCredentials()
        {
            wrongCredInfoLabel.Visible = true;
        }

        //private void Title_Click(object sender, EventArgs e)
        //{

        //}

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

        //private void connectBtn_Click(object sender, EventArgs e)
        //{
        //    MainForm mainform = new MainForm(User, );
        //    this.Close();
        //}
    }
}
