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

namespace App
{
    public partial class AlbumForm : Form
    {
        private Album _album;

        public AlbumForm(Album album)
        {
            InitializeComponent();
            _album = album;
        }

        private void AlbumForm_Load(object sender, EventArgs e)
        {
            titleTextBox.Text = _album.Title;
            authorsTextBox.Text = string.Join(" ,", _album.Authors);
            publisherTextBox.Text = _album.Publisher;
            isbnTextBox.Text = _album.Isbn;
            categoryTextBox.Text = _album.Category.Name;
            descriptionRichTextBox.Text = _album.Description;

            seriesTextBox.Text = _album.Series?.Name ?? "N/A";
            genresTextBox.Text = _album.Genres.Count > 0
                ? string.Join(", ", _album.Genres)
                : "N/A";

            if (_album.Cover != null)
            {
                MemoryStream stream;
                stream = new MemoryStream(_album.Cover);
                stream.Position = 0;
                coverPictureBox.Image = Image.FromStream(stream);
            }
            else coverPictureBox.Image = Image.FromFile("img/cover_placeholder.png");
        }

        private void categoryTextBox_MouseHover(object sender, EventArgs e)
        {
            albumDetailToolTip.Show(categoryTextBox.Text, categoryTextBox);
        }

        private void genresTextBox_MouseHover(object sender, EventArgs e)
        {
            albumDetailToolTip.Show(genresTextBox.Text, genresTextBox);
        }
    }
}
