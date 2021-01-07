using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Services;
using Domain;

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
            RefreshAlbumViews();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void RefreshAlbumViews()
        {
            //market panel
            //on recupere la liste
            IList<Album> liste = _albumRepository.GetMarketAlbums();
            //on affiche la liste
            for (int i=0;i<liste.Count;i++)
            {
                possessedLayoutPanel.Controls.Add(new PictureBox());
            }
            
            //possessed panel

            //wishes panel
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
