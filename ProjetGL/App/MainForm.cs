using DAL.Services;
using Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App
{
    public partial class MainForm : Form
    {
        private readonly User _user;
        private IAlbumRepository _albumRepository;

        public MainForm(User user, IAlbumRepository albumRepo)
        {
            InitializeComponent();

            _user = user;
            _albumRepository = albumRepo;

            currentUserLabel.Text = user.ToString();
            
            RefreshMarketAlbum();
            RefreshOwnedAlbum();
        }

        private void RefreshMarketAlbum()
        {
            IList<Album> albumList = _albumRepository.GetAll();
            //_albumRepository.GetOwnedAlbums(_user);

            int i = 0; int y = 0;

            foreach (var album in albumList)
            {
                // Set curstom control properties
                AlbumQuickView view = new AlbumQuickView
                {
                    Name = $"marketAlbumViewDetail{i}",
                    TabIndex = i++,
                    
                    // Set custom control data
                    Album = album,
                    DisplayStar = false
                };

                marketFlowLayoutPanel.Controls.Add(view);
                y += view.Height;
            }
        }

        private void RefreshOwnedAlbum()
        {
            IList<Album> albumList = _user.OwnedAlbums;

            int i = 0; int y = 0;

            foreach (var album in albumList)
            {
                // Set custom control properties
                AlbumQuickView view = new AlbumQuickView
                {
                    Name = $"marketAlbumViewDetail{i}",
                    TabIndex = i++,

                    // Set custom control data
                    Album = album,
                    DisplayStar = true,

                    IsLiked = _user.LikedAlbums.Contains(album)
                };

                ownedFlowLayoutPanel.Controls.Add(view);
                y += view.Height;
            }
        }

        private void RefreshWishedAlbum()
        {
            IList<Album> userWishedAlbums = _user.WishedAlbums;

            int i = 0;
            int y = 0;

            foreach (var album in userWishedAlbums)
            {
                // Set curstom control properties
                AlbumQuickView view = new AlbumQuickView
                {
                    Location = new System.Drawing.Point(1, -1 + y),
                    Name = $"ownedAlbumViewDetail{i}",
                    TabIndex = i++,

                    // Set custom control data
                    Album = album,
                    DisplayStar = false,
                };

                wishesFlowLayoutPanel.Controls.Add(view);
                y += view.Height;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
