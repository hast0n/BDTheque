
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
            this.components = new System.ComponentModel.Container();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.albumDetailToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.Location = new System.Drawing.Point(0, 0);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(182, 250);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPictureBox.TabIndex = 0;
            this.coverPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoEllipsis = true;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(3, 253);
            this.titleLabel.MaximumSize = new System.Drawing.Size(180, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(87, 20);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Album Title";
            this.titleLabel.MouseHover += new System.EventHandler(this.titleLabel_MouseHover);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(7, 277);
            this.authorLabel.MaximumSize = new System.Drawing.Size(303, 13);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(70, 13);
            this.authorLabel.TabIndex = 12;
            this.authorLabel.Text = "Album Author";
            // 
            // AlbumDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.coverPictureBox);
            this.Name = "AlbumDetailView";
            this.Size = new System.Drawing.Size(183, 303);
            this.Load += new System.EventHandler(this.AlbumDetailView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.ToolTip albumDetailToolTip;
    }
}
