
namespace App
{
    partial class MainForm
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.myAlbumsPage = new System.Windows.Forms.TabPage();
            this.ownedFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.marketAlbumsPage = new System.Windows.Forms.TabPage();
            this.marketFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.wishesPage = new System.Windows.Forms.TabPage();
            this.wishedFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.genreRadioButton = new System.Windows.Forms.RadioButton();
            this.seriesRadioButton = new System.Windows.Forms.RadioButton();
            this.authorRadioButton = new System.Windows.Forms.RadioButton();
            this.titleRadioButton = new System.Windows.Forms.RadioButton();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.myAlbumsPage.SuspendLayout();
            this.marketAlbumsPage.SuspendLayout();
            this.wishesPage.SuspendLayout();
            this.searchOptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.myAlbumsPage);
            this.mainTabControl.Controls.Add(this.marketAlbumsPage);
            this.mainTabControl.Controls.Add(this.wishesPage);
            this.mainTabControl.Location = new System.Drawing.Point(11, 151);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(889, 579);
            this.mainTabControl.TabIndex = 4;
            // 
            // myAlbumsPage
            // 
            this.myAlbumsPage.Controls.Add(this.ownedFlowLayoutPanel);
            this.myAlbumsPage.Location = new System.Drawing.Point(4, 22);
            this.myAlbumsPage.Margin = new System.Windows.Forms.Padding(2);
            this.myAlbumsPage.Name = "myAlbumsPage";
            this.myAlbumsPage.Padding = new System.Windows.Forms.Padding(2);
            this.myAlbumsPage.Size = new System.Drawing.Size(881, 553);
            this.myAlbumsPage.TabIndex = 0;
            this.myAlbumsPage.Text = "Albums possédés";
            this.myAlbumsPage.UseVisualStyleBackColor = true;
            // 
            // ownedFlowLayoutPanel
            // 
            this.ownedFlowLayoutPanel.AutoScroll = true;
            this.ownedFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownedFlowLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.ownedFlowLayoutPanel.Name = "ownedFlowLayoutPanel";
            this.ownedFlowLayoutPanel.Size = new System.Drawing.Size(877, 549);
            this.ownedFlowLayoutPanel.TabIndex = 0;
            // 
            // marketAlbumsPage
            // 
            this.marketAlbumsPage.Controls.Add(this.marketFlowLayoutPanel);
            this.marketAlbumsPage.Location = new System.Drawing.Point(4, 22);
            this.marketAlbumsPage.Margin = new System.Windows.Forms.Padding(2);
            this.marketAlbumsPage.Name = "marketAlbumsPage";
            this.marketAlbumsPage.Padding = new System.Windows.Forms.Padding(2);
            this.marketAlbumsPage.Size = new System.Drawing.Size(881, 553);
            this.marketAlbumsPage.TabIndex = 1;
            this.marketAlbumsPage.Text = "Albums sur le marché ";
            this.marketAlbumsPage.UseVisualStyleBackColor = true;
            // 
            // marketFlowLayoutPanel
            // 
            this.marketFlowLayoutPanel.AutoScroll = true;
            this.marketFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marketFlowLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.marketFlowLayoutPanel.Name = "marketFlowLayoutPanel";
            this.marketFlowLayoutPanel.Size = new System.Drawing.Size(877, 549);
            this.marketFlowLayoutPanel.TabIndex = 0;
            // 
            // wishesPage
            // 
            this.wishesPage.Controls.Add(this.wishedFlowLayoutPanel);
            this.wishesPage.Cursor = System.Windows.Forms.Cursors.Default;
            this.wishesPage.Location = new System.Drawing.Point(4, 22);
            this.wishesPage.Margin = new System.Windows.Forms.Padding(2);
            this.wishesPage.Name = "wishesPage";
            this.wishesPage.Size = new System.Drawing.Size(881, 553);
            this.wishesPage.TabIndex = 2;
            this.wishesPage.Text = "Mes souhaits";
            this.wishesPage.UseVisualStyleBackColor = true;
            // 
            // wishedFlowLayoutPanel
            // 
            this.wishedFlowLayoutPanel.AutoScroll = true;
            this.wishedFlowLayoutPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.wishedFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wishedFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.wishedFlowLayoutPanel.Name = "wishedFlowLayoutPanel";
            this.wishedFlowLayoutPanel.Size = new System.Drawing.Size(881, 553);
            this.wishedFlowLayoutPanel.TabIndex = 0;
            this.wishedFlowLayoutPanel.WrapContents = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.AllowDrop = true;
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BackColor = System.Drawing.Color.Beige;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchTextBox.Location = new System.Drawing.Point(6, 60);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(751, 23);
            this.searchTextBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchButton.Location = new System.Drawing.Point(763, 50);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(114, 33);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Rechercher";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchOptionsGroupBox
            // 
            this.searchOptionsGroupBox.Controls.Add(this.searchTextBox);
            this.searchOptionsGroupBox.Controls.Add(this.searchButton);
            this.searchOptionsGroupBox.Controls.Add(this.genreRadioButton);
            this.searchOptionsGroupBox.Controls.Add(this.seriesRadioButton);
            this.searchOptionsGroupBox.Controls.Add(this.authorRadioButton);
            this.searchOptionsGroupBox.Controls.Add(this.titleRadioButton);
            this.searchOptionsGroupBox.Location = new System.Drawing.Point(11, 48);
            this.searchOptionsGroupBox.Name = "searchOptionsGroupBox";
            this.searchOptionsGroupBox.Size = new System.Drawing.Size(883, 89);
            this.searchOptionsGroupBox.TabIndex = 0;
            this.searchOptionsGroupBox.TabStop = false;
            this.searchOptionsGroupBox.Text = "Options de recherches";
            // 
            // genreRadioButton
            // 
            this.genreRadioButton.AutoSize = true;
            this.genreRadioButton.Location = new System.Drawing.Point(158, 37);
            this.genreRadioButton.Name = "genreRadioButton";
            this.genreRadioButton.Size = new System.Drawing.Size(54, 17);
            this.genreRadioButton.TabIndex = 3;
            this.genreRadioButton.Text = "Genre";
            this.genreRadioButton.UseVisualStyleBackColor = true;
            this.genreRadioButton.CheckedChanged += new System.EventHandler(this.genreRadioButton_CheckedChanged);
            // 
            // seriesRadioButton
            // 
            this.seriesRadioButton.AutoSize = true;
            this.seriesRadioButton.Location = new System.Drawing.Point(158, 19);
            this.seriesRadioButton.Name = "seriesRadioButton";
            this.seriesRadioButton.Size = new System.Drawing.Size(91, 17);
            this.seriesRadioButton.TabIndex = 2;
            this.seriesRadioButton.Text = "Série de livres";
            this.seriesRadioButton.UseVisualStyleBackColor = true;
            this.seriesRadioButton.CheckedChanged += new System.EventHandler(this.seriesRadioButton_CheckedChanged);
            // 
            // authorRadioButton
            // 
            this.authorRadioButton.AutoSize = true;
            this.authorRadioButton.Location = new System.Drawing.Point(6, 37);
            this.authorRadioButton.Name = "authorRadioButton";
            this.authorRadioButton.Size = new System.Drawing.Size(56, 17);
            this.authorRadioButton.TabIndex = 1;
            this.authorRadioButton.Text = "Auteur";
            this.authorRadioButton.UseVisualStyleBackColor = true;
            this.authorRadioButton.CheckedChanged += new System.EventHandler(this.authorRadioButton_CheckedChanged);
            // 
            // titleRadioButton
            // 
            this.titleRadioButton.AutoSize = true;
            this.titleRadioButton.Checked = true;
            this.titleRadioButton.Location = new System.Drawing.Point(6, 19);
            this.titleRadioButton.Name = "titleRadioButton";
            this.titleRadioButton.Size = new System.Drawing.Size(125, 17);
            this.titleRadioButton.TabIndex = 0;
            this.titleRadioButton.TabStop = true;
            this.titleRadioButton.Text = "Titre ou partie du titre";
            this.titleRadioButton.UseVisualStyleBackColor = true;
            this.titleRadioButton.CheckedChanged += new System.EventHandler(this.titleRadioButton_CheckedChanged);
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.currentUserLabel.Location = new System.Drawing.Point(700, 14);
            this.currentUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currentUserLabel.Size = new System.Drawing.Size(200, 13);
            this.currentUserLabel.TabIndex = 1;
            this.currentUserLabel.Text = "Utilisateur";
            this.currentUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.welcomeLabel.Location = new System.Drawing.Point(11, 13);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(495, 17);
            this.welcomeLabel.TabIndex = 5;
            this.welcomeLabel.Text = "Bienvenu dans votre BDThèque, faites comme chez vous, c\'est moi qui offre !";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 741);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.searchOptionsGroupBox);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.currentUserLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(927, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BDThèque";
            this.mainTabControl.ResumeLayout(false);
            this.myAlbumsPage.ResumeLayout(false);
            this.marketAlbumsPage.ResumeLayout(false);
            this.wishesPage.ResumeLayout(false);
            this.searchOptionsGroupBox.ResumeLayout(false);
            this.searchOptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage myAlbumsPage;
        private System.Windows.Forms.TabPage marketAlbumsPage;
        private System.Windows.Forms.FlowLayoutPanel ownedFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel marketFlowLayoutPanel;
        private System.Windows.Forms.TabPage wishesPage;
        private System.Windows.Forms.FlowLayoutPanel wishedFlowLayoutPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox searchOptionsGroupBox;
        private System.Windows.Forms.RadioButton genreRadioButton;
        private System.Windows.Forms.RadioButton seriesRadioButton;
        private System.Windows.Forms.RadioButton authorRadioButton;
        private System.Windows.Forms.RadioButton titleRadioButton;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Label welcomeLabel;
    }
}