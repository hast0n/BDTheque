
namespace App
{
    partial class AlbumQuickView
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
            this.starredPictureBox = new System.Windows.Forms.PictureBox();
            this.wishedPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starredPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wishedPictureBox)).BeginInit();
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
            this.titleLabel.Location = new System.Drawing.Point(3, 259);
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
            this.authorLabel.Location = new System.Drawing.Point(6, 284);
            this.authorLabel.MaximumSize = new System.Drawing.Size(180, 13);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(70, 13);
            this.authorLabel.TabIndex = 12;
            this.authorLabel.Text = "Album Author";
            this.authorLabel.MouseHover += new System.EventHandler(this.authorLabel_MouseHover);
            // 
            // starredPictureBox
            // 
            this.starredPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.starredPictureBox.Location = new System.Drawing.Point(160, 3);
            this.starredPictureBox.Name = "starredPictureBox";
            this.starredPictureBox.Size = new System.Drawing.Size(20, 20);
            this.starredPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.starredPictureBox.TabIndex = 13;
            this.starredPictureBox.TabStop = false;
            this.starredPictureBox.Click += new System.EventHandler(this.starredPictureBox_Click);
            this.starredPictureBox.MouseHover += new System.EventHandler(this.starredPictureBox_MouseHover);
            // 
            // wishedPictureBox
            // 
            this.wishedPictureBox.Location = new System.Drawing.Point(0, 0);
            this.wishedPictureBox.Name = "wishedPictureBox";
            this.wishedPictureBox.Size = new System.Drawing.Size(50, 50);
            this.wishedPictureBox.TabIndex = 14;
            this.wishedPictureBox.TabStop = false;
            this.albumDetailToolTip.SetToolTip(this.wishedPictureBox, "Vous souhaitez obtenir cet album !");
            // 
            // AlbumQuickView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.wishedPictureBox);
            this.Controls.Add(this.starredPictureBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.coverPictureBox);
            this.Name = "AlbumQuickView";
            this.Size = new System.Drawing.Size(183, 303);
            this.Load += new System.EventHandler(this.AlbumDetailView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starredPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wishedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.ToolTip albumDetailToolTip;
        private System.Windows.Forms.PictureBox starredPictureBox;
        private System.Windows.Forms.PictureBox wishedPictureBox;
    }
}
