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
using Domain;

namespace App
{
    public partial class AlbumDetailView : UserControl
    {
        public Album Album;
        public bool DisplayStar;
        public bool IsLiked;

        public AlbumDetailView()
        {
            InitializeComponent();
        }

        private void AlbumDetailView_Load(object sender, EventArgs e)
        {

        }
        public void AlbumRefreshDetails()
        {
            titleLabel.Text = Album.Title;
            publisherLabel.Text = Album.Publisher;
            if (Album.Series != null)
            {
                seriesLabel.Text = Album.Series.Name;
            }
            descriptionLabel.Text = Album.Description;
            isbnLabel.Text = Album.Isbn;

            //cover display
            if (Album.Cover != null)
            {
                MemoryStream stream;
                stream = new MemoryStream(Album.Cover.File);
                stream.Position = 0;
                coverPictureBox.Image = Image.FromStream(stream);
            }
        }
    }
}
