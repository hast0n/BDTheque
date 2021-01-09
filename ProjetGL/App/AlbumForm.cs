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
            AlbumRefreshDetails();
        }

        private void AlbumForm_Load(object sender, EventArgs e)
        {

        }
        public void AlbumRefreshDetails()
        {
            //title
            titleLabel.Text = _album.Title;
            //publisher
            publisherLabel.Text = _album.Publisher;
            //la serie
            if (_album.Series != null)
            {
                seriesLabel.Text = _album.Series.Name;
            }
            //description
            descriptionLabel.Text = _album.Description;
            //Isbn
            isbnLabel.Text = _album.Isbn;
            ////les auteurs
            //string stringToWrite = "";
            //for (int i=0; i<_album.Authors.Count();i++)
            //{
            //    stringToWrite += _album.Authors[i].Name;
            //}
            //authorsLabel.Text = stringToWrite;
            ////les genres
            //stringToWrite = "";
            //for (int i = 0; i < _album.Genres.Count(); i++)
            //{
            //    stringToWrite += _album.Genres[i].Name;
            //}
            //genresLabel.Text = stringToWrite;
            //category
            categoryLabel.Text = _album.Category.Name;
            //cover display
            if (_album.Cover != null)
            {
                MemoryStream stream;
                stream = new MemoryStream(_album.Cover.File);
                stream.Position = 0;
                coverPictureBox.Image = Image.FromStream(stream);
            }
        }
    }
}
