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
        public byte[] Cover { get; set; }

        public Series Series
        {
            get
            {
                var selectedItem = seriesComboBox.SelectedItem;

                if (selectedItem.Equals(_defautSeries))
                    return null;
                
                return (Series)selectedItem;
            }
        }

        private Series _defautSeries = new Series("Aucune");

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
            categoryComboBox.DataSource = _albumRepository.GetCategories();
            
            var series = _albumRepository.GetSeries();
            series.Insert(0, _defautSeries);
            seriesComboBox.DataSource = series;

            UpdateCoverPictureBox();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string message = "Le champ \"{0}\" est incomplet, veuillez réessayer.";
            string caption = "Champ invalide";
            string field = string.Empty;

            if (string.IsNullOrWhiteSpace(Title)) field = "Titre";
            else if (string.IsNullOrWhiteSpace(Publisher)) field = "Éditeur";
            else if (Authors.Count < 1) field = "Auteur(s)";
            else if (string.IsNullOrWhiteSpace(Description)) field = "Description";
            else if (string.IsNullOrWhiteSpace(Publisher)) field = "ISBN-10 / ASIN";
            else if (Category is null) field = "Category";
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
                
                FileInfo fi = new FileInfo(file);
                long fileSize = fi.Length; //The size of the current file in bytes.file 

                if (fileSize > 65535)
                {
                    MessageBox.Show(
                        $"L'image de couverture spécifiée dépasse les 65535kio (taille : {fileSize}kio), veuillez en essayer une autre.",
                        "Image trop lourde",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                try
                {
                    Cover = Album.GetByteArrayFromImage(file);
                }
                catch (IOException)
                {
                    MessageBox.Show(
                        "Nous n'avons pas réussi à importer le fichier, veuillez réeesayer.",
                        "Erreur d'importation",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }

                UpdateCoverPictureBox();
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
