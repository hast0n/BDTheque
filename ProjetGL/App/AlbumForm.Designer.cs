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
            this.publisherLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.seriesLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.isbnInfoLabel = new System.Windows.Forms.Label();
            this.authorsLabel = new System.Windows.Forms.Label();
            this.genresLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLabel.Location = new System.Drawing.Point(285, 205);
            this.publisherLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(128, 20);
            this.publisherLabel.TabIndex = 14;
            this.publisherLabel.Text = "Publisher Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoEllipsis = true;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(285, 263);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.MaximumSize = new System.Drawing.Size(592, 206);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionLabel.TabIndex = 13;
            this.descriptionLabel.Text = "Description";
            // 
            // seriesLabel
            // 
            this.seriesLabel.AutoSize = true;
            this.seriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriesLabel.Location = new System.Drawing.Point(285, 232);
            this.seriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seriesLabel.Name = "seriesLabel";
            this.seriesLabel.Size = new System.Drawing.Size(106, 20);
            this.seriesLabel.TabIndex = 12;
            this.seriesLabel.Text = "Series Name";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(284, 41);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(110, 25);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Album Title";
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.coverPictureBox.Location = new System.Drawing.Point(0, 0);
            this.coverPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(243, 450);
            this.coverPictureBox.TabIndex = 15;
            this.coverPictureBox.TabStop = false;
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Location = new System.Drawing.Point(699, 412);
            this.isbnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(47, 17);
            this.isbnLabel.TabIndex = 17;
            this.isbnLabel.Text = "[ISBN]";
            // 
            // isbnInfoLabel
            // 
            this.isbnInfoLabel.AutoSize = true;
            this.isbnInfoLabel.Location = new System.Drawing.Point(572, 412);
            this.isbnInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isbnInfoLabel.Name = "isbnInfoLabel";
            this.isbnInfoLabel.Size = new System.Drawing.Size(111, 17);
            this.isbnInfoLabel.TabIndex = 16;
            this.isbnInfoLabel.Text = "ISBN-10 / ASIN :";
            // 
            // authorsLabel
            // 
            this.authorsLabel.AutoSize = true;
            this.authorsLabel.Location = new System.Drawing.Point(288, 81);
            this.authorsLabel.Name = "authorsLabel";
            this.authorsLabel.Size = new System.Drawing.Size(57, 17);
            this.authorsLabel.TabIndex = 18;
            this.authorsLabel.Text = "Authors";
            // 
            // genresLabel
            // 
            this.genresLabel.AutoSize = true;
            this.genresLabel.Location = new System.Drawing.Point(291, 119);
            this.genresLabel.Name = "genresLabel";
            this.genresLabel.Size = new System.Drawing.Size(55, 17);
            this.genresLabel.TabIndex = 19;
            this.genresLabel.Text = "Genres";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(291, 154);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(65, 17);
            this.categoryLabel.TabIndex = 20;
            this.categoryLabel.Text = "Category";
            // 
            // AlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.genresLabel);
            this.Controls.Add(this.authorsLabel);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.isbnInfoLabel);
            this.Controls.Add(this.coverPictureBox);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.seriesLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "AlbumForm";
            this.Text = "AlbumForm";
            this.Load += new System.EventHandler(this.AlbumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label seriesLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.Label isbnInfoLabel;
        private System.Windows.Forms.Label authorsLabel;
        private System.Windows.Forms.Label genresLabel;
        private System.Windows.Forms.Label categoryLabel;
    }
}