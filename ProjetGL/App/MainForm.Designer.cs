
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
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.myAlbumsPage = new System.Windows.Forms.TabPage();
            this.ownedFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.marketAlbumsPage = new System.Windows.Forms.TabPage();
            this.wishesPage = new System.Windows.Forms.TabPage();
            this.AlbumFormBtn = new System.Windows.Forms.Button();
            this.marketFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.albumDetailView1 = new App.AlbumDetailView();
            this.mainTabControl.SuspendLayout();
            this.myAlbumsPage.SuspendLayout();
            this.ownedFlowLayoutPanel.SuspendLayout();
            this.marketAlbumsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Location = new System.Drawing.Point(868, 9);
            this.currentUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(38, 13);
            this.currentUserLabel.TabIndex = 1;
            this.currentUserLabel.Text = "Aucun";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.myAlbumsPage);
            this.mainTabControl.Controls.Add(this.marketAlbumsPage);
            this.mainTabControl.Controls.Add(this.wishesPage);
            this.mainTabControl.Location = new System.Drawing.Point(11, 24);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(715, 418);
            this.mainTabControl.TabIndex = 4;
            // 
            // myAlbumsPage
            // 
            this.myAlbumsPage.Controls.Add(this.ownedFlowLayoutPanel);
            this.myAlbumsPage.Location = new System.Drawing.Point(4, 22);
            this.myAlbumsPage.Margin = new System.Windows.Forms.Padding(2);
            this.myAlbumsPage.Name = "myAlbumsPage";
            this.myAlbumsPage.Padding = new System.Windows.Forms.Padding(2);
            this.myAlbumsPage.Size = new System.Drawing.Size(707, 392);
            this.myAlbumsPage.TabIndex = 0;
            this.myAlbumsPage.Text = "Albums possédés";
            this.myAlbumsPage.UseVisualStyleBackColor = true;
            // 
            // ownedFlowLayoutPanel
            // 
            this.ownedFlowLayoutPanel.Controls.Add(this.albumDetailView1);
            this.ownedFlowLayoutPanel.Location = new System.Drawing.Point(5, 5);
            this.ownedFlowLayoutPanel.Name = "ownedFlowLayoutPanel";
            this.ownedFlowLayoutPanel.Size = new System.Drawing.Size(697, 382);
            this.ownedFlowLayoutPanel.TabIndex = 0;
            // 
            // marketAlbumsPage
            // 
            this.marketAlbumsPage.Controls.Add(this.marketFlowLayoutPanel);
            this.marketAlbumsPage.Location = new System.Drawing.Point(4, 22);
            this.marketAlbumsPage.Margin = new System.Windows.Forms.Padding(2);
            this.marketAlbumsPage.Name = "marketAlbumsPage";
            this.marketAlbumsPage.Padding = new System.Windows.Forms.Padding(2);
            this.marketAlbumsPage.Size = new System.Drawing.Size(707, 392);
            this.marketAlbumsPage.TabIndex = 1;
            this.marketAlbumsPage.Text = "Albums sur le marché ";
            this.marketAlbumsPage.UseVisualStyleBackColor = true;
            // 
            // wishesPage
            // 
            this.wishesPage.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.wishesPage.Location = new System.Drawing.Point(4, 22);
            this.wishesPage.Margin = new System.Windows.Forms.Padding(2);
            this.wishesPage.Name = "wishesPage";
            this.wishesPage.Size = new System.Drawing.Size(707, 392);
            this.wishesPage.TabIndex = 2;
            this.wishesPage.Text = "Mes souhaits";
            this.wishesPage.UseVisualStyleBackColor = true;
            this.wishesPage.UseWaitCursor = true;
            // 
            // AlbumFormBtn
            // 
            this.AlbumFormBtn.Location = new System.Drawing.Point(762, 461);
            this.AlbumFormBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AlbumFormBtn.Name = "AlbumFormBtn";
            this.AlbumFormBtn.Size = new System.Drawing.Size(88, 19);
            this.AlbumFormBtn.TabIndex = 5;
            this.AlbumFormBtn.Text = "un album ";
            this.AlbumFormBtn.UseVisualStyleBackColor = true;
            this.AlbumFormBtn.Click += new System.EventHandler(this.AlbumFormBtn_Click);
            // 
            // marketFlowLayoutPanel
            // 
            this.marketFlowLayoutPanel.Location = new System.Drawing.Point(5, 5);
            this.marketFlowLayoutPanel.Name = "marketFlowLayoutPanel";
            this.marketFlowLayoutPanel.Size = new System.Drawing.Size(697, 382);
            this.marketFlowLayoutPanel.TabIndex = 0;
            // 
            // albumDetailView1
            // 
            this.albumDetailView1.Location = new System.Drawing.Point(3, 3);
            this.albumDetailView1.Name = "albumDetailView1";
            this.albumDetailView1.Size = new System.Drawing.Size(648, 299);
            this.albumDetailView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 491);
            this.Controls.Add(this.AlbumFormBtn);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.currentUserLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.mainTabControl.ResumeLayout(false);
            this.myAlbumsPage.ResumeLayout(false);
            this.ownedFlowLayoutPanel.ResumeLayout(false);
            this.marketAlbumsPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage myAlbumsPage;
        private System.Windows.Forms.TabPage marketAlbumsPage;
        private System.Windows.Forms.TabPage wishesPage;
        private System.Windows.Forms.Button AlbumFormBtn;
        private System.Windows.Forms.FlowLayoutPanel ownedFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel marketFlowLayoutPanel;
        private AlbumDetailView albumDetailView1;
    }
}