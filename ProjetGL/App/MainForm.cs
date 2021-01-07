using DAL.Services;
using Domain;
using System;
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
            currentUserLabel.Text = user.FirstName + " " + user.LastName;

        }
    }
}
