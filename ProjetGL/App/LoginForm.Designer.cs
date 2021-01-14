
namespace App
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginInfoLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wrongCredInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(121, 75);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(90, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Nom d\'utilisateur :";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(121, 113);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(77, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Mot de passe :";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(217, 72);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(217, 110);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // loginInfoLabel
            // 
            this.loginInfoLabel.AutoSize = true;
            this.loginInfoLabel.Location = new System.Drawing.Point(99, 29);
            this.loginInfoLabel.Name = "loginInfoLabel";
            this.loginInfoLabel.Size = new System.Drawing.Size(284, 13);
            this.loginInfoLabel.TabIndex = 4;
            this.loginInfoLabel.Text = "Connectez-vous pour accéder à votre espace bibliothèque";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(217, 154);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 23);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Connexion";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // wrongCredInfoLabel
            // 
            this.wrongCredInfoLabel.AutoSize = true;
            this.wrongCredInfoLabel.BackColor = System.Drawing.SystemColors.Control;
            this.wrongCredInfoLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.wrongCredInfoLabel.Location = new System.Drawing.Point(121, 192);
            this.wrongCredInfoLabel.Name = "wrongCredInfoLabel";
            this.wrongCredInfoLabel.Size = new System.Drawing.Size(280, 13);
            this.wrongCredInfoLabel.TabIndex = 6;
            this.wrongCredInfoLabel.Text = "Les informartions saisies sont erronées. Veuillez réessayer.";
            this.wrongCredInfoLabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 229);
            this.Controls.Add(this.wrongCredInfoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginInfoLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "LoginForm";
            this.Text = "BDThèque - Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label loginInfoLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wrongCredInfoLabel;
    }
}

