﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.myAlbumsPage = new System.Windows.Forms.TabPage();
            this.marketAlbumsPage = new System.Windows.Forms.TabPage();
            this.wishesPage = new System.Windows.Forms.TabPage();
            this.mainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilisateur actuel:";
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Location = new System.Drawing.Point(688, 20);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(48, 17);
            this.currentUserLabel.TabIndex = 1;
            this.currentUserLabel.Text = "Aucun";
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.Transparent;
            this.connectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.connectBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.connectBtn.Location = new System.Drawing.Point(576, 50);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(83, 26);
            this.connectBtn.TabIndex = 2;
            this.connectBtn.Text = "S\'identifier";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Enabled = false;
            this.disconnectBtn.Location = new System.Drawing.Point(665, 50);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(123, 26);
            this.disconnectBtn.TabIndex = 3;
            this.disconnectBtn.Text = "Se déconnecter";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.myAlbumsPage);
            this.mainTabControl.Controls.Add(this.marketAlbumsPage);
            this.mainTabControl.Controls.Add(this.wishesPage);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(555, 426);
            this.mainTabControl.TabIndex = 4;
            // 
            // myAlbumsPage
            // 
            this.myAlbumsPage.Location = new System.Drawing.Point(4, 25);
            this.myAlbumsPage.Name = "myAlbumsPage";
            this.myAlbumsPage.Padding = new System.Windows.Forms.Padding(3);
            this.myAlbumsPage.Size = new System.Drawing.Size(547, 397);
            this.myAlbumsPage.TabIndex = 0;
            this.myAlbumsPage.Text = "Albums possédés";
            this.myAlbumsPage.UseVisualStyleBackColor = true;
            // 
            // marketAlbumsPage
            // 
            this.marketAlbumsPage.Location = new System.Drawing.Point(4, 25);
            this.marketAlbumsPage.Name = "marketAlbumsPage";
            this.marketAlbumsPage.Padding = new System.Windows.Forms.Padding(3);
            this.marketAlbumsPage.Size = new System.Drawing.Size(547, 397);
            this.marketAlbumsPage.TabIndex = 1;
            this.marketAlbumsPage.Text = "Albums sur le marché ";
            this.marketAlbumsPage.UseVisualStyleBackColor = true;
            // 
            // wishesPage
            // 
            this.wishesPage.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.wishesPage.Location = new System.Drawing.Point(4, 25);
            this.wishesPage.Name = "wishesPage";
            this.wishesPage.Size = new System.Drawing.Size(547, 397);
            this.wishesPage.TabIndex = 2;
            this.wishesPage.Text = "Mes souhaits";
            this.wishesPage.UseVisualStyleBackColor = true;
            this.wishesPage.UseWaitCursor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage myAlbumsPage;
        private System.Windows.Forms.TabPage marketAlbumsPage;
        private System.Windows.Forms.TabPage wishesPage;
    }
}