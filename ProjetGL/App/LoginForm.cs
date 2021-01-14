using DAL.Services;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DAL;
using DAL.Tools;
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                loginButton.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
