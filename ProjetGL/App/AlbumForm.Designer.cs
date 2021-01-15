namespace App
{
    partial class AlbumForm
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
            this.components = new System.ComponentModel.Container();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.isbnInfoLabel = new System.Windows.Forms.Label();
            this.categoryInfoLabel = new System.Windows.Forms.Label();
            this.genresInfoLabel = new System.Windows.Forms.Label();
            this.titleInfoLabel = new System.Windows.Forms.Label();
            this.authorInfoLabel = new System.Windows.Forms.Label();
            this.publisherInfoLabel = new System.Windows.Forms.Label();
            this.seriesInfoLabel = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.descriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.albumDetailToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorsTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.seriesTextBox = new System.Windows.Forms.TextBox();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.genresTextBox = new System.Windows.Forms.TextBox();
            this.manageOwnedButton = new System.Windows.Forms.Button();
            this.manageWishListButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.descriptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.Location = new System.Drawing.Point(12, 12);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(200, 274);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPictureBox.TabIndex = 15;
            this.coverPictureBox.TabStop = false;
            // 
            // isbnInfoLabel
            // 
            this.isbnInfoLabel.AutoSize = true;
            this.isbnInfoLabel.Location = new System.Drawing.Point(12, 310);
            this.isbnInfoLabel.Name = "isbnInfoLabel";
            this.isbnInfoLabel.Size = new System.Drawing.Size(89, 13);
            this.isbnInfoLabel.TabIndex = 16;
            this.isbnInfoLabel.Text = "ISBN-10 / ASIN :";
            // 
            // categoryInfoLabel
            // 
            this.categoryInfoLabel.AutoSize = true;
            this.categoryInfoLabel.Location = new System.Drawing.Point(13, 335);
            this.categoryInfoLabel.Name = "categoryInfoLabel";
            this.categoryInfoLabel.Size = new System.Drawing.Size(58, 13);
            this.categoryInfoLabel.TabIndex = 22;
            this.categoryInfoLabel.Text = "Catégorie :";
            // 
            // genresInfoLabel
            // 
            this.genresInfoLabel.AutoSize = true;
            this.genresInfoLabel.Location = new System.Drawing.Point(14, 363);
            this.genresInfoLabel.Name = "genresInfoLabel";
            this.genresInfoLabel.Size = new System.Drawing.Size(47, 13);
            this.genresInfoLabel.TabIndex = 23;
            this.genresInfoLabel.Text = "Genres :";
            // 
            // titleInfoLabel
            // 
            this.titleInfoLabel.AutoSize = true;
            this.titleInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.titleInfoLabel.Location = new System.Drawing.Point(295, 17);
            this.titleInfoLabel.Name = "titleInfoLabel";
            this.titleInfoLabel.Size = new System.Drawing.Size(37, 15);
            this.titleInfoLabel.TabIndex = 24;
            this.titleInfoLabel.Text = "Titre :";
            // 
            // authorInfoLabel
            // 
            this.authorInfoLabel.AutoSize = true;
            this.authorInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.authorInfoLabel.Location = new System.Drawing.Point(274, 54);
            this.authorInfoLabel.Name = "authorInfoLabel";
            this.authorInfoLabel.Size = new System.Drawing.Size(62, 15);
            this.authorInfoLabel.TabIndex = 25;
            this.authorInfoLabel.Text = "Auteur(s) :";
            // 
            // publisherInfoLabel
            // 
            this.publisherInfoLabel.AutoSize = true;
            this.publisherInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.publisherInfoLabel.Location = new System.Drawing.Point(283, 89);
            this.publisherInfoLabel.Name = "publisherInfoLabel";
            this.publisherInfoLabel.Size = new System.Drawing.Size(52, 15);
            this.publisherInfoLabel.TabIndex = 26;
            this.publisherInfoLabel.Text = "Éditeur :";
            // 
            // seriesInfoLabel
            // 
            this.seriesInfoLabel.AutoSize = true;
            this.seriesInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.seriesInfoLabel.Location = new System.Drawing.Point(250, 123);
            this.seriesInfoLabel.Name = "seriesInfoLabel";
            this.seriesInfoLabel.Size = new System.Drawing.Size(90, 15);
            this.seriesInfoLabel.TabIndex = 27;
            this.seriesInfoLabel.Text = "Série de livres :";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionRichTextBox.Location = new System.Drawing.Point(10, 24);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.ReadOnly = true;
            this.descriptionRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.descriptionRichTextBox.Size = new System.Drawing.Size(526, 260);
            this.descriptionRichTextBox.TabIndex = 29;
            this.descriptionRichTextBox.Text = "";
            // 
            // descriptionGroupBox
            // 
            this.descriptionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionGroupBox.Controls.Add(this.descriptionRichTextBox);
            this.descriptionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.descriptionGroupBox.Location = new System.Drawing.Point(253, 163);
            this.descriptionGroupBox.Name = "descriptionGroupBox";
            this.descriptionGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.descriptionGroupBox.Size = new System.Drawing.Size(546, 294);
            this.descriptionGroupBox.TabIndex = 30;
            this.descriptionGroupBox.TabStop = false;
            this.descriptionGroupBox.Text = "Description de l\'ouvrage :";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titleTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.titleTextBox.Location = new System.Drawing.Point(354, 13);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(445, 19);
            this.titleTextBox.TabIndex = 31;
            this.titleTextBox.Text = "Title";
            // 
            // authorsTextBox
            // 
            this.authorsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorsTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.authorsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.authorsTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.authorsTextBox.Location = new System.Drawing.Point(354, 54);
            this.authorsTextBox.Name = "authorsTextBox";
            this.authorsTextBox.ReadOnly = true;
            this.authorsTextBox.Size = new System.Drawing.Size(445, 16);
            this.authorsTextBox.TabIndex = 32;
            this.authorsTextBox.Text = "Authors";
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publisherTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.publisherTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.publisherTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.publisherTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.publisherTextBox.Location = new System.Drawing.Point(354, 89);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.ReadOnly = true;
            this.publisherTextBox.Size = new System.Drawing.Size(445, 16);
            this.publisherTextBox.TabIndex = 33;
            this.publisherTextBox.Text = "Publisher";
            // 
            // seriesTextBox
            // 
            this.seriesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seriesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seriesTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.seriesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.seriesTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.seriesTextBox.Location = new System.Drawing.Point(354, 123);
            this.seriesTextBox.Name = "seriesTextBox";
            this.seriesTextBox.ReadOnly = true;
            this.seriesTextBox.Size = new System.Drawing.Size(445, 16);
            this.seriesTextBox.TabIndex = 34;
            this.seriesTextBox.Text = "Series";
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.isbnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.isbnTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.isbnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.isbnTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.isbnTextBox.Location = new System.Drawing.Point(107, 308);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.ReadOnly = true;
            this.isbnTextBox.Size = new System.Drawing.Size(158, 14);
            this.isbnTextBox.TabIndex = 35;
            this.isbnTextBox.Text = "[ISBN]";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.categoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.categoryTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.categoryTextBox.Location = new System.Drawing.Point(77, 333);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.ReadOnly = true;
            this.categoryTextBox.Size = new System.Drawing.Size(188, 14);
            this.categoryTextBox.TabIndex = 36;
            this.categoryTextBox.Text = "Category";
            this.categoryTextBox.MouseHover += new System.EventHandler(this.categoryTextBox_MouseHover);
            // 
            // genresTextBox
            // 
            this.genresTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genresTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genresTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.genresTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.genresTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.genresTextBox.Location = new System.Drawing.Point(67, 361);
            this.genresTextBox.Multiline = true;
            this.genresTextBox.Name = "genresTextBox";
            this.genresTextBox.ReadOnly = true;
            this.genresTextBox.Size = new System.Drawing.Size(198, 85);
            this.genresTextBox.TabIndex = 37;
            this.genresTextBox.Text = "Genres";
            this.genresTextBox.MouseHover += new System.EventHandler(this.genresTextBox_MouseHover);
            // 
            // manageOwnedButton
            // 
            this.manageOwnedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.manageOwnedButton.BackColor = System.Drawing.Color.PaleGreen;
            this.manageOwnedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manageOwnedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.manageOwnedButton.Location = new System.Drawing.Point(661, 466);
            this.manageOwnedButton.Name = "manageOwnedButton";
            this.manageOwnedButton.Size = new System.Drawing.Size(138, 67);
            this.manageOwnedButton.TabIndex = 38;
            this.manageOwnedButton.Text = "Ajouter à ma collection";
            this.manageOwnedButton.UseVisualStyleBackColor = false;
            this.manageOwnedButton.Click += new System.EventHandler(this.manageOwnedButton_Click);
            // 
            // manageWishListButton
            // 
            this.manageWishListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.manageWishListButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.manageWishListButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manageWishListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.manageWishListButton.Location = new System.Drawing.Point(503, 466);
            this.manageWishListButton.Name = "manageWishListButton";
            this.manageWishListButton.Size = new System.Drawing.Size(138, 67);
            this.manageWishListButton.TabIndex = 39;
            this.manageWishListButton.Text = "Ajouter à ma liste de souhaits";
            this.manageWishListButton.UseVisualStyleBackColor = false;
            this.manageWishListButton.Click += new System.EventHandler(this.manageWishListButton_Click);
            // 
            // AlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 542);
            this.Controls.Add(this.manageWishListButton);
            this.Controls.Add(this.manageOwnedButton);
            this.Controls.Add(this.genresTextBox);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(this.seriesTextBox);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.authorsTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.descriptionGroupBox);
            this.Controls.Add(this.seriesInfoLabel);
            this.Controls.Add(this.publisherInfoLabel);
            this.Controls.Add(this.authorInfoLabel);
            this.Controls.Add(this.titleInfoLabel);
            this.Controls.Add(this.genresInfoLabel);
            this.Controls.Add(this.categoryInfoLabel);
            this.Controls.Add(this.isbnInfoLabel);
            this.Controls.Add(this.coverPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(809, 497);
            this.Name = "AlbumForm";
            this.Text = "AlbumForm";
            this.Load += new System.EventHandler(this.AlbumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.descriptionGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.Label isbnInfoLabel;
        private System.Windows.Forms.Label categoryInfoLabel;
        private System.Windows.Forms.Label genresInfoLabel;
        private System.Windows.Forms.Label titleInfoLabel;
        private System.Windows.Forms.Label authorInfoLabel;
        private System.Windows.Forms.Label publisherInfoLabel;
        private System.Windows.Forms.Label seriesInfoLabel;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.GroupBox descriptionGroupBox;
        private System.Windows.Forms.ToolTip albumDetailToolTip;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorsTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox seriesTextBox;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox genresTextBox;
        private System.Windows.Forms.Button manageOwnedButton;
        private System.Windows.Forms.Button manageWishListButton;
    }
}