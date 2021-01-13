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
            authorLabel.Text = String.Join(", ", Album.Authors);

            //cover display
            if (Album.Cover != null) // theoretically not possible but in any case of failure to retrieve blob...
            {
                MemoryStream stream;
                stream = new MemoryStream(Album.Cover);
                stream.Position = 0;
                coverPictureBox.Image = Image.FromStream(stream);
            }
            else
            {
                coverPictureBox.Image = Image.FromFile("img/cover_placeholder.png");
            }
        }

        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            AlbumForm albumForm = new AlbumForm(Album);
            if (albumForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void titleLabel_MouseHover(object sender, EventArgs e)
        {
            albumDetailToolTip.Show(Album.Title, titleLabel);
        }
    }
}
