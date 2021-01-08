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
using DAL;
using DAL.Repositories;
using DAL.Services;
using Domain;

namespace App
{
    public partial class AlbumForm : Form
    {
        private readonly ICoverRepository _blobImgRepository = new CoverRepository();
        public AlbumForm(Album album)
        {
            InitializeComponent();
            //MemoryStream stream = new MemoryStream(blobimg.File);
            //stream.Position = 0;
            //pictureBox1.Image = Image.FromStream(stream);
            ////essai de mise d'un blob en BDD
            //_blobImgRepository.Save(blobimg);
            //essai de requete d'un album en BDD
            //Cover newBlobImg = _blobImgRepository.GetCoverById(album.Id);
            //affichage
            MemoryStream stream;
            stream = new MemoryStream(album.Cover.File);
            stream.Position = 0;
            pictureBox1.Image = Image.FromStream(stream);
        }

        private void AlbumForm_Load(object sender, EventArgs e)
        {

        }
    }
}
