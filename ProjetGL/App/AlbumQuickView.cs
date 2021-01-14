using DAL.Services;
using Domain;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using App.Properties;

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
                wishedPictureBox.Image = Properties.Resources.wished;
                wishedPictureBox.Visible = true;
                wishedPictureBox.Parent = coverPictureBox;
                wishedPictureBox.BackColor = Color.Transparent;
                wishedPictureBox.BringToFront();
            }
            else wishedPictureBox.Visible = false;

            if (Album.Cover != null) // theoretically not possible but in any case of failure to retrieve blob...
            {
                MemoryStream stream = new MemoryStream(Album.Cover);
                stream.Position = 0;
                coverPictureBox.Image = Image.FromStream(stream);
            }
            else coverPictureBox.Image = Resources.cover_placeholder;

            var toAvoid = new[] {"starredPictureBox", "wishedPictureBox"};

            foreach (Control c in this.Controls)
                if (!toAvoid.Contains(c.Name))
                    c.Click += albumDetailEvent_handler_click;

            UpdateStarredPictureBox();
        }

        private void UpdateStarredPictureBox()
        {
            if (IsLiked) starredPictureBox.Image = Resources.starred;
            else starredPictureBox.Image = Resources.not_starred;
        }

        private void albumDetailEvent_handler_click(object sender, EventArgs e)
        {
            AlbumForm detailsForm = new AlbumForm()
            {
                User = User, 
                Album = Album,
                IsOwned = DisplayStarred,
                IsWished = DisplayWished,

                UserRepository = UserRepository
            };
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
            albumDetailToolTip.Show(IsLiked ? "Ajouté à votre liste des favoris" : "Ajoutez cet album à votre liste des favoris", starredPictureBox);
        }

        private void wishedPictureBox_Click(object sender, EventArgs e)
        {
            albumDetailToolTip.Show("Ajouté à votre liste de souhaits", wishedPictureBox);
        }
    }
}
