
namespace App
{
    partial class AlbumDetailView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.seriesLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.isbnInfoLabel = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.coverPictureBox.Location = new System.Drawing.Point(0, 0);
            this.coverPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(243, 368);
            this.coverPictureBox.TabIndex = 0;
            this.coverPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(251, 12);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(110, 25);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Album Title";
            // 
            // seriesLabel
            // 
            this.seriesLabel.AutoSize = true;
            this.seriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriesLabel.Location = new System.Drawing.Point(252, 69);
            this.seriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seriesLabel.Name = "seriesLabel";
            this.seriesLabel.Size = new System.Drawing.Size(106, 20);
            this.seriesLabel.TabIndex = 2;
            this.seriesLabel.Text = "Series Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoEllipsis = true;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(252, 100);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.MaximumSize = new System.Drawing.Size(592, 206);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description";
            // 
            // isbnInfoLabel
            // 
            this.isbnInfoLabel.AutoSize = true;
            this.isbnInfoLabel.Location = new System.Drawing.Point(560, 340);
            this.isbnInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isbnInfoLabel.Name = "isbnInfoLabel";
            this.isbnInfoLabel.Size = new System.Drawing.Size(111, 17);
            this.isbnInfoLabel.TabIndex = 8;
            this.isbnInfoLabel.Text = "ISBN-10 / ASIN :";
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Location = new System.Drawing.Point(687, 340);
            this.isbnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(47, 17);
            this.isbnLabel.TabIndex = 9;
            this.isbnLabel.Text = "[ISBN]";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLabel.Location = new System.Drawing.Point(252, 42);
            this.publisherLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(128, 20);
            this.publisherLabel.TabIndex = 10;
            this.publisherLabel.Text = "Publisher Name";
            // 
            // AlbumDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.isbnInfoLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.seriesLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.coverPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AlbumDetailView";
            this.Size = new System.Drawing.Size(864, 368);
            this.Load += new System.EventHandler(this.AlbumDetailView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label seriesLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label isbnInfoLabel;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.Label publisherLabel;
    }
}
