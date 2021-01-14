using DAL.Services;
using Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace App
{
    public partial class MainForm : Form
    {
        private enum SearchType
        {
            Title, Author, Series, Genre
        }

        private SearchType _currentSearchType;
        private readonly User _user;
        private readonly IAlbumRepository _albumRepository;
        private readonly IUserRepository _userRepository;

        private const string SearchBarPlaceholder = "Rechercher un album sur le marché ...";

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

            searchTextBox.GotFocus += RemoveText;
            searchTextBox.LostFocus += AddText;

            searchTextBox.ForeColor = Color.Gray;
            searchTextBox.Text = SearchBarPlaceholder;

            _currentSearchType = SearchType.Title;
        }
        
        public void RemoveText(object sender, EventArgs e)
        {
            if (searchTextBox.Text == SearchBarPlaceholder)
            {
                searchTextBox.ForeColor = Color.Black;
                searchTextBox.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                searchTextBox.ForeColor = Color.Gray;
                searchTextBox.Text = SearchBarPlaceholder;
            }
        }

        private void RefreshMarketAlbum(IList<Album> albumList = null)
        {
            marketFlowLayoutPanel.Controls.Clear();

            if (albumList is null) albumList = _albumRepository.GetAll();
            //albumList ??= _albumRepository.GetAll(); //not available in C#7.3 grrr!

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

        private void searchButton_Click(object sender, EventArgs e)
        {
            string search = searchTextBox.Text != SearchBarPlaceholder
                ? searchTextBox.Text
                : "";

            IList<Album> result = null;

            switch (_currentSearchType)
            {
                case SearchType.Title:
                    result =_albumRepository.GetByTitle(search);
                    break;
                case SearchType.Author:
                    result = _albumRepository.GetByAuthor(search);
                    break;
                case SearchType.Series:
                    result = _albumRepository.GetBySeries(search);
                    break;
                case SearchType.Genre:
                    result = _albumRepository.GetByGenre(search);
                    break;
            }

            RefreshMarketAlbum(result);
            mainTabControl.SelectedTab = marketAlbumsPage;
        }

        private void titleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _currentSearchType = SearchType.Title;
        }

        private void authorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _currentSearchType = SearchType.Author;
        }

        private void seriesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _currentSearchType = SearchType.Series;
        }

        private void genreRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _currentSearchType = SearchType.Genre;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter) && searchTextBox.Focused)
            {
                searchButton.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
