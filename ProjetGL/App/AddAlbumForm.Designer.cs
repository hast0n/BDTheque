namespace App
{
    partial class AddAlbumForm
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.authorsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.genresCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.seriesComboBox = new System.Windows.Forms.ComboBox();
            this.coverOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.addCoverButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.descriptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coverPictureBox.Location = new System.Drawing.Point(26, 17);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(200, 274);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPictureBox.TabIndex = 15;
            this.coverPictureBox.TabStop = false;
            // 
            // isbnInfoLabel
            // 
            this.isbnInfoLabel.AutoSize = true;
            this.isbnInfoLabel.Location = new System.Drawing.Point(12, 363);
            this.isbnInfoLabel.Name = "isbnInfoLabel";
            this.isbnInfoLabel.Size = new System.Drawing.Size(89, 13);
            this.isbnInfoLabel.TabIndex = 16;
            this.isbnInfoLabel.Text = "ISBN-10 / ASIN :";
            // 
            // categoryInfoLabel
            // 
            this.categoryInfoLabel.AutoSize = true;
            this.categoryInfoLabel.Location = new System.Drawing.Point(12, 394);
            this.categoryInfoLabel.Name = "categoryInfoLabel";
            this.categoryInfoLabel.Size = new System.Drawing.Size(58, 13);
            this.categoryInfoLabel.TabIndex = 22;
            this.categoryInfoLabel.Text = "Catégorie :";
            // 
            // genresInfoLabel
            // 
            this.genresInfoLabel.AutoSize = true;
            this.genresInfoLabel.Location = new System.Drawing.Point(12, 425);
            this.genresInfoLabel.Name = "genresInfoLabel";
            this.genresInfoLabel.Size = new System.Drawing.Size(53, 13);
            this.genresInfoLabel.TabIndex = 23;
            this.genresInfoLabel.Text = "Genre(s) :";
            // 
            // titleInfoLabel
            // 
            this.titleInfoLabel.AutoSize = true;
            this.titleInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.titleInfoLabel.Location = new System.Drawing.Point(276, 17);
            this.titleInfoLabel.Name = "titleInfoLabel";
            this.titleInfoLabel.Size = new System.Drawing.Size(37, 15);
            this.titleInfoLabel.TabIndex = 24;
            this.titleInfoLabel.Text = "Titre :";
            // 
            // authorInfoLabel
            // 
            this.authorInfoLabel.AutoSize = true;
            this.authorInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.authorInfoLabel.Location = new System.Drawing.Point(276, 124);
            this.authorInfoLabel.Name = "authorInfoLabel";
            this.authorInfoLabel.Size = new System.Drawing.Size(62, 15);
            this.authorInfoLabel.TabIndex = 25;
            this.authorInfoLabel.Text = "Auteur(s) :";
            // 
            // publisherInfoLabel
            // 
            this.publisherInfoLabel.AutoSize = true;
            this.publisherInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.publisherInfoLabel.Location = new System.Drawing.Point(276, 53);
            this.publisherInfoLabel.Name = "publisherInfoLabel";
            this.publisherInfoLabel.Size = new System.Drawing.Size(52, 15);
            this.publisherInfoLabel.TabIndex = 26;
            this.publisherInfoLabel.Text = "Éditeur :";
            // 
            // seriesInfoLabel
            // 
            this.seriesInfoLabel.AutoSize = true;
            this.seriesInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.seriesInfoLabel.Location = new System.Drawing.Point(276, 89);
            this.seriesInfoLabel.Name = "seriesInfoLabel";
            this.seriesInfoLabel.Size = new System.Drawing.Size(90, 15);
            this.seriesInfoLabel.TabIndex = 27;
            this.seriesInfoLabel.Text = "Série de livres :";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.BackColor = System.Drawing.Color.White;
            this.descriptionRichTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionRichTextBox.Location = new System.Drawing.Point(10, 24);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.descriptionRichTextBox.Size = new System.Drawing.Size(375, 206);
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
            this.descriptionGroupBox.Location = new System.Drawing.Point(269, 289);
            this.descriptionGroupBox.Name = "descriptionGroupBox";
            this.descriptionGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.descriptionGroupBox.Size = new System.Drawing.Size(395, 240);
            this.descriptionGroupBox.TabIndex = 30;
            this.descriptionGroupBox.TabStop = false;
            this.descriptionGroupBox.Text = "Description de l\'ouvrage :";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.titleTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.titleTextBox.Location = new System.Drawing.Point(319, 14);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(345, 23);
            this.titleTextBox.TabIndex = 31;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publisherTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.publisherTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.publisherTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.publisherTextBox.Location = new System.Drawing.Point(334, 50);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(330, 23);
            this.publisherTextBox.TabIndex = 33;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.isbnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.isbnTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.isbnTextBox.Location = new System.Drawing.Point(107, 358);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(140, 21);
            this.isbnTextBox.TabIndex = 35;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveButton.Location = new System.Drawing.Point(531, 544);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(136, 45);
            this.saveButton.TabIndex = 38;
            this.saveButton.Text = "Enregistrer";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // authorsCheckedListBox
            // 
            this.authorsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorsCheckedListBox.CheckOnClick = true;
            this.authorsCheckedListBox.FormattingEnabled = true;
            this.authorsCheckedListBox.Location = new System.Drawing.Point(344, 124);
            this.authorsCheckedListBox.Name = "authorsCheckedListBox";
            this.authorsCheckedListBox.Size = new System.Drawing.Size(320, 154);
            this.authorsCheckedListBox.Sorted = true;
            this.authorsCheckedListBox.TabIndex = 39;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancelButton.Location = new System.Drawing.Point(367, 544);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 45);
            this.cancelButton.TabIndex = 41;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(76, 391);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(171, 21);
            this.categoryComboBox.TabIndex = 42;
            // 
            // genresCheckedListBox
            // 
            this.genresCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.genresCheckedListBox.CheckOnClick = true;
            this.genresCheckedListBox.FormattingEnabled = true;
            this.genresCheckedListBox.Location = new System.Drawing.Point(65, 425);
            this.genresCheckedListBox.Name = "genresCheckedListBox";
            this.genresCheckedListBox.Size = new System.Drawing.Size(182, 94);
            this.genresCheckedListBox.Sorted = true;
            this.genresCheckedListBox.TabIndex = 43;
            // 
            // seriesComboBox
            // 
            this.seriesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seriesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.seriesComboBox.FormattingEnabled = true;
            this.seriesComboBox.Location = new System.Drawing.Point(372, 85);
            this.seriesComboBox.Name = "seriesComboBox";
            this.seriesComboBox.Size = new System.Drawing.Size(292, 24);
            this.seriesComboBox.TabIndex = 44;
            // 
            // coverOpenFileDialog
            // 
            this.coverOpenFileDialog.FileName = "tmp_cover";
            this.coverOpenFileDialog.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";
            // 
            // addCoverButton
            // 
            this.addCoverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.addCoverButton.Location = new System.Drawing.Point(65, 297);
            this.addCoverButton.Name = "addCoverButton";
            this.addCoverButton.Size = new System.Drawing.Size(161, 23);
            this.addCoverButton.TabIndex = 45;
            this.addCoverButton.Text = "Modifier la couverture";
            this.addCoverButton.UseVisualStyleBackColor = true;
            this.addCoverButton.Click += new System.EventHandler(this.addCoverButton_Click);
            // 
            // AddAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 601);
            this.Controls.Add(this.addCoverButton);
            this.Controls.Add(this.seriesComboBox);
            this.Controls.Add(this.genresCheckedListBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.authorsCheckedListBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(this.publisherTextBox);
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
            this.MinimumSize = new System.Drawing.Size(684, 640);
            this.Name = "AddAlbumForm";
            this.Text = "AlbumForm";
            this.Load += new System.EventHandler(this.AddAlbumForm_Load);
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
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckedListBox authorsCheckedListBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.CheckedListBox genresCheckedListBox;
        private System.Windows.Forms.ComboBox seriesComboBox;
        private System.Windows.Forms.OpenFileDialog coverOpenFileDialog;
        private System.Windows.Forms.Button addCoverButton;
    }
}