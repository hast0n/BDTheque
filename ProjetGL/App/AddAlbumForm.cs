using DAL.Services;
using Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using App.Properties;

namespace App
{
    public partial class AddAlbumForm : Form
    {
        public string Title => titleTextBox.Text.Trim();
        public string Publisher => publisherTextBox.Text.Trim();
        public string Isbn => isbnTextBox.Text.Trim();
        public string Description => descriptionRichTextBox.Text.Trim();
        public Category Category => (Category)categoryComboBox.SelectedItem;
        public Series Series => (Series)seriesComboBox.SelectedItem;
        public byte[] Cover { get; set; }

        public List<Author> Authors {
            get
            {
                var names = authorsCheckedListBox.CheckedItems;
                return _albumRepository.GetAuthors().Where(a => names.Contains(a.Name)).ToList();
            }
        }
        
        public List<Genre> Genres {
            get
            {
                var names = genresCheckedListBox.CheckedItems;
                return _albumRepository.GetGenres().Where(g => names.Contains(g.Name)).ToList();

            }
        }

        private IAlbumRepository _albumRepository;

        public AddAlbumForm(IAlbumRepository albumRepo)
        {
            InitializeComponent();
            _albumRepository = albumRepo;
            Cover = null;
        }

        private void AddAlbumForm_Load(object sender, EventArgs e)
        {
            string[] authors = _albumRepository.GetAuthors().Select(a => a.Name).ToArray();
            string[] genres = _albumRepository.GetGenres().Select(g => g.Name).ToArray();

            authorsCheckedListBox.Items.AddRange(authors);
            genresCheckedListBox.Items.AddRange(genres);
            seriesComboBox.DataSource = _albumRepository.GetSeries();
            categoryComboBox.DataSource = _albumRepository.GetCategories();

            UpdateCoverPictureBox();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string message = "Le champ \"{0}\" est incomplet, veuillez réessayer.";
            string caption = "Champ invalide";
            string field = string.Empty;

            if (string.IsNullOrWhiteSpace(Title)) field = "Titre";
            else if (string.IsNullOrWhiteSpace(Publisher)) field = "Éditeur";
            else if (Series is null) field = "Série de livres";
            else if (Authors.Count < 1) field = "Auteur(s)";
            else if (string.IsNullOrWhiteSpace(Description)) field = "Description";
            else if (string.IsNullOrWhiteSpace(Publisher)) field = "ISBN-10 / ASIN";
            else if (Category is null) field = "Category";
            else if (Genres.Count < 1) field = "Genre(s)";
            else if (Cover is null) field = "Image de couverture";

            if (!string.IsNullOrEmpty(field))
            {
                MessageBox.Show(string.Format(message, field), caption, 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void addCoverButton_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = coverOpenFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {

                string file = coverOpenFileDialog.FileName;
                try
                {
                    Cover = Album.GetByteArrayFromImage(file);
                    UpdateCoverPictureBox();
                }
                catch (IOException)
                {
                    MessageBox.Show(
                        "Le fichier spécifié est invalide, veuillez réeesayer.",
                        "Format invalide",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateCoverPictureBox()
        {
            if (Cover != null)
            {
                MemoryStream stream = new MemoryStream(Cover);
                stream.Position = 0;
                coverPictureBox.Image = Image.FromStream(stream);
            }
            else coverPictureBox.Image = Resources.cover_placeholder;
        }
    }
}
