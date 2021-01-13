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
        public Album _album;

        public AlbumForm(Album album)
        {
            InitializeComponent();
            _album = album;
        }

        private void AlbumForm_Load(object sender, EventArgs e)
        {
            titleLabel.Text = _album.Title;
            publisherLabel.Text = _album.Publisher;
            descriptionLabel.Text = _album.Description;
            isbnLabel.Text = _album.Isbn;
            categoryLabel.Text = _album.Category.ToString();
            
            if (_album.Series != null)
            {
                seriesLabel.Text = _album.Series.Name;
            }
         
            if (_album.Cover != null)
            {
                MemoryStream stream;
                stream = new MemoryStream(_album.Cover);
                stream.Position = 0;
                coverPictureBox.Image = Image.FromStream(stream);
            }
            else coverPictureBox.Image = Image.FromFile("img/cover_placeholder.png");

        }
    }
}
