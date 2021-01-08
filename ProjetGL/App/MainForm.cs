using DAL.Services;
using Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace App
{
    public partial class MainForm : Form
    {
        private readonly User _user;
        private IAlbumRepository _albumRepository;
        public MainForm(User user, IAlbumRepository albumRepo, ICoverRepository coverRepo)
        {
            InitializeComponent();

            _user = user;
            _albumRepository = albumRepo;
            currentUserLabel.Text = user.FirstName + " " + user.LastName;
            MemoryStream stream;
            //stream = new MemoryStream(coverRepo.GetCoverById(14).File);
            var hehe = _albumRepository.GetAlbumById(12).Cover;
            stream = new MemoryStream(hehe.File);
            stream.Position = 0;
            pictureBox1.Image = Image.FromStream(stream);
            //RefreshAlbumViews();
            return;
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void RefreshAlbumViews()
        {
            //market panel
            //on recupere la liste
            //IList<Album> liste = _albumRepository.GetMarketAlbums();
            _albumRepository.GetOwnedAlbums(_user);
            //on affiche la liste
            //for (int i=0;i<liste.Count;i++)
            //{
            //    possessedLayoutPanel.Controls.Add(new PictureBox());
            //}
            
            //possessed panel

            //wishes panel
        }

        private void myAlbumsPage_Click(object sender, EventArgs e)
        {

        }

        private void AlbumFormBtn_Click(object sender, EventArgs e)
        {
            
            AlbumForm albumForm = new AlbumForm(_albumRepository.GetAlbumById(12));
            if (albumForm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
