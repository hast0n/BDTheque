
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
            this.wishedFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
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
            this.currentUserLabel.Location = new System.Drawing.Point(854, 9);
            this.currentUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(38, 13);
            this.currentUserLabel.TabIndex = 1;
            this.currentUserLabel.Text = "Aucun";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.myAlbumsPage);
            this.mainTabControl.Controls.Add(this.marketAlbumsPage);
            this.mainTabControl.Controls.Add(this.wishesPage);
            this.mainTabControl.Location = new System.Drawing.Point(11, 24);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(794, 608);
            this.mainTabControl.TabIndex = 4;
            // 
            // myAlbumsPage
            // 
            this.myAlbumsPage.Controls.Add(this.ownedFlowLayoutPanel);
            this.myAlbumsPage.Location = new System.Drawing.Point(4, 22);
            this.myAlbumsPage.Margin = new System.Windows.Forms.Padding(2);
            this.myAlbumsPage.Name = "myAlbumsPage";
            this.myAlbumsPage.Padding = new System.Windows.Forms.Padding(2);
            this.myAlbumsPage.Size = new System.Drawing.Size(786, 582);
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
            this.ownedFlowLayoutPanel.Size = new System.Drawing.Size(782, 578);
            this.ownedFlowLayoutPanel.TabIndex = 0;
            // 
            // marketAlbumsPage
            // 
            this.marketAlbumsPage.Controls.Add(this.marketFlowLayoutPanel);
            this.marketAlbumsPage.Location = new System.Drawing.Point(4, 22);
            this.marketAlbumsPage.Margin = new System.Windows.Forms.Padding(2);
            this.marketAlbumsPage.Name = "marketAlbumsPage";
            this.marketAlbumsPage.Padding = new System.Windows.Forms.Padding(2);
            this.marketAlbumsPage.Size = new System.Drawing.Size(786, 582);
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
            this.marketFlowLayoutPanel.Size = new System.Drawing.Size(782, 578);
            this.marketFlowLayoutPanel.TabIndex = 0;
            // 
            // wishesPage
            // 
            this.wishesPage.Controls.Add(this.wishedFlowLayoutPanel);
            this.wishesPage.Cursor = System.Windows.Forms.Cursors.Default;
            this.wishesPage.Location = new System.Drawing.Point(4, 22);
            this.wishesPage.Margin = new System.Windows.Forms.Padding(2);
            this.wishesPage.Name = "wishesPage";
            this.wishesPage.Size = new System.Drawing.Size(786, 582);
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
            this.wishedFlowLayoutPanel.Size = new System.Drawing.Size(786, 582);
            this.wishedFlowLayoutPanel.TabIndex = 0;
            this.wishedFlowLayoutPanel.WrapContents = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 681);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.currentUserLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BDThèque";
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
        private System.Windows.Forms.FlowLayoutPanel ownedFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel marketFlowLayoutPanel;
        private AlbumQuickView _albumQuickView1;
        private System.Windows.Forms.TabPage wishesPage;
        private System.Windows.Forms.FlowLayoutPanel wishedFlowLayoutPanel;
    }
}