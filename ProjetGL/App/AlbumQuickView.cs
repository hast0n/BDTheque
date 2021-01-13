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
    public partial class AlbumQuickView : UserControl
    {
        public Album Album;
        public bool DisplayStar;
        public bool IsLiked;

        private string _authorsString => String.Join(", ", Album.Authors);

        public AlbumQuickView()
        {
            InitializeComponent();
        }

        private void AlbumDetailView_Load(object sender, EventArgs e)
        {
            starredPictureBox.Visible = DisplayStar;
            starredPictureBox.Parent = coverPictureBox;
            starredPictureBox.BackColor = Color.Transparent;
            starredPictureBox.BringToFront();

            titleLabel.Text = Album.Title;
            authorLabel.Text = _authorsString;

            //cover display
            if (Album.Cover != null) // theoretically not possible but in any case of failure to retrieve blob...
            {
                MemoryStream stream;
                stream = new MemoryStream(Album.Cover);
                stream.Position = 0;
                coverPictureBox.Image = Image.FromStream(stream);
            }
            else coverPictureBox.Image = Image.FromFile("img/cover_placeholder.png");

            if (IsLiked) starredPictureBox.Image = Image.FromFile("img/starred.png");
            else starredPictureBox.Image = Image.FromFile("img/not_starred.png");
            
            foreach (Control c in this.Controls)
                if (!new []{ "starredPictureBox", "wishedPictureBox"}.Contains(c.Name))
                    c.Click += albumDetailEvent_handler_click;
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
    }
}
