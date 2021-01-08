using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
