using Domain;
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

namespace App
{
    public partial class AlbumForm : Form
    {
        public Album Album;
        public bool IsOwned;
        public bool IsWished;
        public User User;
        public IUserRepository UserRepository;

        private bool _isOwned_baseValue;
        private bool _isWished_baseValue;

        public AlbumForm()
        {
            InitializeComponent();
        }

        private void AlbumForm_Load(object sender, EventArgs e)
        {
            _isOwned_baseValue = IsOwned;
            _isWished_baseValue = IsWished;

            titleTextBox.Text = Album.Title;
            authorsTextBox.Text = string.Join(" ,", Album.Authors);
            publisherTextBox.Text = Album.Publisher;
            isbnTextBox.Text = Album.Isbn;
            categoryTextBox.Text = Album.Category.Name;
            descriptionRichTextBox.Text = Album.Description;

            seriesTextBox.Text = Album.Series?.Name ?? "N/A";
            genresTextBox.Text = Album.Genres.Count > 0
                ? string.Join(", ", Album.Genres)
                : "N/A";

            if (Album.Cover != null)
            {
                MemoryStream stream;
                stream = new MemoryStream(Album.Cover);
                stream.Position = 0;
                coverPictureBox.Image = Image.FromStream(stream);
            }
            else coverPictureBox.Image = Image.FromFile("img/cover_placeholder.png");

            if (IsOwned)
            {
                manageOwnedButton.BackColor = Color.Tomato;
                manageOwnedButton.Text = "Retirer de ma collection";

                manageWishListButton.Visible = false;
            }

            if (IsWished)
            {
                manageWishListButton.BackColor = Color.Tomato;
                manageWishListButton.Text = "Retirer de ma liste de souhaits";
            }

            this.FormClosed += OnFormClosedEventHandler;
        }

        private void OnFormClosedEventHandler(object o, FormClosedEventArgs args)
        {
            MainForm.NeedRefresh = _isOwned_baseValue != IsOwned || _isWished_baseValue != IsWished;
        }

        private void categoryTextBox_MouseHover(object sender, EventArgs e)
        {
            albumDetailToolTip.Show(categoryTextBox.Text, categoryTextBox);
        }

        private void genresTextBox_MouseHover(object sender, EventArgs e)
        {
            albumDetailToolTip.Show(genresTextBox.Text, genresTextBox);
        }


        private void manageOwnedButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Voulez-vous vraiment " +
                (IsOwned ? "retirer cet album de" : "ajouter cet album à")
                + " votre collection ?",
                "Confirmez votre choix",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation);

            if (result == DialogResult.OK)
            {
                if (IsOwned) RemoveFromOwned();
                else AddToOwned();
                
                UserRepository.Save(User);
            }
        }

        private void RemoveFromOwned()
        {
            User.OwnedAlbums.Remove(Album);
            manageOwnedButton.BackColor = Color.PaleGreen;
            manageOwnedButton.Text = "Ajouter à ma collection";
            IsOwned = false;

            manageWishListButton.Visible = true;
        }

        private void AddToOwned()
        {
            User.OwnedAlbums.Add(Album);
            manageOwnedButton.BackColor = Color.Tomato;
            manageOwnedButton.Text = "Retirer de ma collection";
            IsOwned = true;

            RemoveFromWished();
            manageWishListButton.Visible = false;
        }


        private void manageWishListButton_Click(object sender, EventArgs e)
        {
            if (IsWished) RemoveFromWished();
            else AddToWished();

            UserRepository.Save(User);
        }

        private void RemoveFromWished()
        {
            User.WishedAlbums.Remove(Album);
            manageWishListButton.BackColor = Color.DeepSkyBlue;
            manageWishListButton.Text = "Ajouter à ma liste de souhaits";
            IsWished = false;
        }

        private void AddToWished()
        {
            User.WishedAlbums.Add(Album);
            manageWishListButton.BackColor = Color.Tomato;
            manageWishListButton.Text = "Retirer de ma liste de souahits";
            IsWished = true;
        }
    }
}
