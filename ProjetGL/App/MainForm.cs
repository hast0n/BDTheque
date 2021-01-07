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
        public MainForm(User user)//, IAlbumRepository albumRepo)
        {
            InitializeComponent();

            _user = user;
            //_albumRepository = albumRepo;
            currentUserLabel.Text = user.FirstName + " " + user.LastName;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void RefreshAlbumViews()
        {
            
        }

        private void myAlbumsPage_Click(object sender, EventArgs e)
        {

        }

        private void AlbumFormBtn_Click(object sender, EventArgs e)
        {
            AlbumForm albumForm = new AlbumForm();
            if (albumForm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
