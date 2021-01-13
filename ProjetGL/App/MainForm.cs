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
        private IUserRepository _userRepository;

        public MainForm(User user, IAlbumRepository albumRepo, IUserRepository userRepo)
        {
            InitializeComponent();

            _user = user;
            _albumRepository = albumRepo;
            _userRepository = userRepo;

            currentUserLabel.Text = user.ToString();
            
            RefreshMarketAlbum();
            RefreshOwnedAlbum();
            RefreshWishedAlbum();
        }

        private void RefreshMarketAlbum()
        {
            IList<Album> albumList = _albumRepository.GetAll();
            //_albumRepository.GetOwnedAlbums(_user);

            int i = 0;

            foreach (var album in albumList)
            {
                // Set curstom control properties
                AlbumQuickView view = new AlbumQuickView
                {
                    Name = $"marketAlbumViewDetail{i}",
                    TabIndex = i++,
                    UserRepository = _userRepository,
                    
                    // Set custom control data
                    Album = album,
                    DisplayStarred = false,
                    DisplayWished = _user.WishedAlbums.Contains(album)
                };

                marketFlowLayoutPanel.Controls.Add(view);
            }
        }

        private void RefreshOwnedAlbum()
        {
            IList<Album> albumList = _user.OwnedAlbums;

            int i = 0;

            foreach (var album in albumList)
            {
                // Set custom control properties
                AlbumQuickView view = new AlbumQuickView
                {
                    Name = $"marketAlbumViewDetail{i}",
                    TabIndex = i++,

                    // Set custom control data
                    Album = album,
                    DisplayStarred = true,
                    DisplayWished = false,

                    User = _user,
                    UserRepository = _userRepository,

                    IsLiked = _user.LikedAlbums.Contains(album)
                };

                ownedFlowLayoutPanel.Controls.Add(view);
            }
        }

        private void RefreshWishedAlbum()
        {
            IList<Album> albumList = _user.WishedAlbums;

            int i = 0;

            foreach (var album in albumList)
            {
                // Set curstom control properties
                AlbumQuickView view = new AlbumQuickView
                {
                    Name = $"wishedAlbumViewDetail{i}",
                    TabIndex = i++,

                    User = _user,
                    UserRepository = _userRepository,

                    // Set custom control data
                    Album = album,
                    DisplayStarred = false,
                    DisplayWished = true
                };

                wishedFlowLayoutPanel.Controls.Add(view);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
