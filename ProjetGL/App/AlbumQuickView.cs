using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Services;
using Domain;

namespace App
{
    public partial class AlbumQuickView : UserControl
    {
        public Album Album;
        public bool DisplayStarred;
        public bool DisplayWished;
        public bool IsLiked;
        public IUserRepository UserRepository;
        public User User;

        private string _authorsString => string.Join(", ", Album.Authors);

        public AlbumQuickView()
        {
            InitializeComponent();
        }

        private void AlbumDetailView_Load(object sender, EventArgs e)
        {
            starredPictureBox.Visible = DisplayStarred;
            starredPictureBox.Parent = coverPictureBox;
            starredPictureBox.BackColor = Color.Transparent;
            starredPictureBox.BringToFront();


            titleLabel.Text = Album.Title;
            authorLabel.Text = _authorsString;

            if (DisplayWished)
            {
                wishedPictureBox.Image = Image.FromFile("img/wished.png");
                wishedPictureBox.Visible = true;
                wishedPictureBox.Parent = coverPictureBox;
                wishedPictureBox.BackColor = Color.Transparent;
                wishedPictureBox.BringToFront();
            }
            else wishedPictureBox.Visible = false;

            if (Album.Cover != null) // theoretically not possible but in any case of failure to retrieve blob...
            {
                MemoryStream stream;
                stream = new MemoryStream(Album.Cover);
                stream.Position = 0;
                coverPictureBox.Image = Image.FromStream(stream);
            }
            else coverPictureBox.Image = Image.FromFile("img/cover_placeholder.png");

            UpdateStarredPictureBox();

            var toAvoid = new[] {"starredPictureBox", "wishedPictureBox"};

            foreach (Control c in this.Controls)
                if (!toAvoid.Contains(c.Name))
                    c.Click += albumDetailEvent_handler_click;
        }

        private void UpdateWishedPictureBox()
        {
            
        }

        private void UpdateStarredPictureBox()
        {
            if (IsLiked) starredPictureBox.Image = Image.FromFile("img/starred.png");
            else starredPictureBox.Image = Image.FromFile("img/not_starred.png");
        }

        private void albumDetailEvent_handler_click(object sender, EventArgs e)
        {
            AlbumForm detailsForm = new AlbumForm(Album);
            detailsForm.ShowDialog();
        }

        private void titleLabel_MouseHover(object sender, EventArgs e)
        {
            albumDetailToolTip.Show(Album.Title, titleLabel);
        }

        private void authorLabel_MouseHover(object sender, EventArgs e)
        {
            albumDetailToolTip.Show(_authorsString, authorLabel);
        }

        private void starredPictureBox_Click(object sender, EventArgs e)
        {
            IsLiked = !IsLiked;
            UpdateStarredPictureBox();

            if (IsLiked) User.LikedAlbums.Add(Album);
            else User.LikedAlbums.Remove(Album);

            UserRepository.Save(User);
        }

        private void starredPictureBox_MouseHover(object sender, EventArgs e)
        {
            albumDetailToolTip.Show(IsLiked ? "Ajouté à votre liste des favoris" : "Ajoutez cet album à votre liste des favoris", authorLabel);
        }
    }
}
