
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
            this.marketFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.wishesPage = new System.Windows.Forms.TabPage();
            this.AlbumFormBtn = new System.Windows.Forms.Button();
            this.wishesFlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mainTabControl.SuspendLayout();
            this.myAlbumsPage.SuspendLayout();
            this.marketAlbumsPage.SuspendLayout();
            this.wishesPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Location = new System.Drawing.Point(1033, 11);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(48, 17);
            this.currentUserLabel.TabIndex = 1;
            this.currentUserLabel.Text = "Aucun";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.myAlbumsPage);
            this.mainTabControl.Controls.Add(this.marketAlbumsPage);
            this.mainTabControl.Controls.Add(this.wishesPage);
            this.mainTabControl.Location = new System.Drawing.Point(15, 30);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(953, 514);
            this.mainTabControl.TabIndex = 4;
            // 
            // myAlbumsPage
            // 
            this.myAlbumsPage.Controls.Add(this.ownedFlowLayoutPanel);
            this.myAlbumsPage.Location = new System.Drawing.Point(4, 25);
            this.myAlbumsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myAlbumsPage.Name = "myAlbumsPage";
            this.myAlbumsPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myAlbumsPage.Size = new System.Drawing.Size(945, 485);
            this.myAlbumsPage.TabIndex = 0;
            this.myAlbumsPage.Text = "Albums possédés";
            this.myAlbumsPage.UseVisualStyleBackColor = true;
            // 
            // ownedFlowLayoutPanel
            // 
            this.ownedFlowLayoutPanel.AutoScroll = true;
            this.ownedFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ownedFlowLayoutPanel.Location = new System.Drawing.Point(7, 6);
            this.ownedFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ownedFlowLayoutPanel.Name = "ownedFlowLayoutPanel";
            this.ownedFlowLayoutPanel.Size = new System.Drawing.Size(929, 470);
            this.ownedFlowLayoutPanel.TabIndex = 0;
            this.ownedFlowLayoutPanel.WrapContents = false;
            // 
            // marketAlbumsPage
            // 
            this.marketAlbumsPage.Controls.Add(this.marketFlowLayoutPanel);
            this.marketAlbumsPage.Location = new System.Drawing.Point(4, 25);
            this.marketAlbumsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marketAlbumsPage.Name = "marketAlbumsPage";
            this.marketAlbumsPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marketAlbumsPage.Size = new System.Drawing.Size(945, 485);
            this.marketAlbumsPage.TabIndex = 1;
            this.marketAlbumsPage.Text = "Albums sur le marché ";
            this.marketAlbumsPage.UseVisualStyleBackColor = true;
            // 
            // marketFlowLayoutPanel
            // 
            this.marketFlowLayoutPanel.AutoScroll = true;
            this.marketFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.marketFlowLayoutPanel.Location = new System.Drawing.Point(7, 6);
            this.marketFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.marketFlowLayoutPanel.Name = "marketFlowLayoutPanel";
            this.marketFlowLayoutPanel.Size = new System.Drawing.Size(929, 470);
            this.marketFlowLayoutPanel.TabIndex = 0;
            this.marketFlowLayoutPanel.WrapContents = false;
            // 
            // wishesPage
            // 
            this.wishesPage.Controls.Add(this.wishesFlowLayoutPanel1);
            this.wishesPage.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.wishesPage.Location = new System.Drawing.Point(4, 25);
            this.wishesPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wishesPage.Name = "wishesPage";
            this.wishesPage.Size = new System.Drawing.Size(945, 485);
            this.wishesPage.TabIndex = 2;
            this.wishesPage.Text = "Mes souhaits";
            this.wishesPage.UseVisualStyleBackColor = true;
            this.wishesPage.UseWaitCursor = true;
            // 
            // AlbumFormBtn
            // 
            this.AlbumFormBtn.Location = new System.Drawing.Point(1016, 567);
            this.AlbumFormBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AlbumFormBtn.Name = "AlbumFormBtn";
            this.AlbumFormBtn.Size = new System.Drawing.Size(117, 23);
            this.AlbumFormBtn.TabIndex = 5;
            this.AlbumFormBtn.Text = "un album ";
            this.AlbumFormBtn.UseVisualStyleBackColor = true;
            this.AlbumFormBtn.Click += new System.EventHandler(this.AlbumFormBtn_Click);
            // 
            // wishesFlowLayoutPanel1
            // 
            this.wishesFlowLayoutPanel1.AutoScroll = true;
            this.wishesFlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.wishesFlowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.wishesFlowLayoutPanel1.Name = "wishesFlowLayoutPanel1";
            this.wishesFlowLayoutPanel1.Size = new System.Drawing.Size(939, 479);
            this.wishesFlowLayoutPanel1.TabIndex = 0;
            this.wishesFlowLayoutPanel1.WrapContents = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1223, 604);
            this.Controls.Add(this.AlbumFormBtn);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.currentUserLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.myAlbumsPage.ResumeLayout(false);
            this.marketAlbumsPage.ResumeLayout(false);
            this.wishesPage.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel wishesFlowLayoutPanel1;
    }
}