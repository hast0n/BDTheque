using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using DAL.Repositories;
using System.Collections.Generic;

namespace DALTests
{
    /// <summary>
    /// Description résumée pour AlbumRepositoryTests
    /// </summary>
    [TestClass]
    public class AlbumRepositoryTests
    {
        [TestInitialize()]
        public void Initialyse()
        {
            TestRepository.ClearSession();
            TestRepository.ResetBDD();
        }
        [TestMethod]
        public void GetByTitleTest()
        {
            var albumRepository = new AlbumRepository();
            var allAlbum = albumRepository.GetByTitle("Tome 1 - Planète Dakoï");
            string actualAlbum = "";
            foreach (Album aa in allAlbum)
            {
                actualAlbum += aa.ToString() + ", ";
            }
            string expectedAlbum = "Tome 1 - Planète Dakoï, Bandes dessinées, Soleil Productions, ";
            Assert.AreEqual(actualAlbum, expectedAlbum);
        }
        [TestMethod]
        public void GetByAuthorTest()
        {
            var albumRepository = new AlbumRepository();
            var allAlbum = albumRepository.GetByAuthor("Crisse");
            string actualAlbum = "";
            foreach (Album aa in allAlbum)
            {
                actualAlbum += aa.ToString() + ", ";
            }
            string expectedAlbum = "Tome 1 - Planète Dakoï, Bandes dessinées, Soleil Productions, ";
            Assert.AreEqual(actualAlbum, expectedAlbum);
        }
        [TestMethod]
        public void GetBySeriesTest()
        {
            var albumRepository = new AlbumRepository();
            var allAlbum = albumRepository.GetBySeries("Kookaburra");
            string actualAlbum = "";
            foreach (Album aa in allAlbum)
            {
                actualAlbum += aa.ToString() + ", ";
            }
            string expectedAlbum = "Tome 1 - Planète Dakoï, Bandes dessinées, Soleil Productions, ";
            Assert.AreEqual(expectedAlbum, actualAlbum);
        }
        [TestMethod]
        public void GetByGenreTest()
        {
            var albumRepository = new AlbumRepository();
            var allAlbum = albumRepository.GetByGenre("Science Fiction");
            string actualAlbum = "";
            foreach (Album aa in allAlbum)
            {
                actualAlbum += aa.ToString() + ", ";
            }
            string expectedAlbum = "Tome 1 - Planète Dakoï, Bandes dessinées, Soleil Productions, ";
            Assert.AreEqual(actualAlbum, expectedAlbum);
        }
        [TestMethod]
        public void AlbumGetAllTest()
        {
            var albumRepository = new AlbumRepository();
            var allAlbum = albumRepository.GetAll();
            Assert.AreEqual(3, allAlbum.Count);
            string actualAlbum = "";
            foreach (Album aa in allAlbum)
            {
                actualAlbum += aa.ToString() + ", ";
            }
            string expectedAlbum = "Fullmetal Alchemist - tome 01, Manga, Kurokawa, Fullmetal Alchemist - tome 02, Manga, Kurokawa, Tome 1 - Planète Dakoï, Bandes dessinées, Soleil Productions, ";
            Assert.AreEqual(actualAlbum, expectedAlbum);
        }
        [TestMethod]
        public void SaveAlbumTest()
        {
            var albumRepository = new AlbumRepository();
            var newAlbum = new Album("Titre", "99334", "Publisher", "Decription", new List<Author> { new Author("Author") }, new List<Genre> { new Genre("Genre") }, new Category("Category"), new Series("Series"), );
            albumRepository.Save(newAlbum);
            var allAlbum = albumRepository.GetAll();
            Assert.AreEqual(8, allAlbum.Count);
            string actualAlbum = "";
            foreach (Album aa in allAlbum)
            {
                actualAlbum += aa.ToString() + ", ";
            }
            string expectedAlbum = "Baptiste Pesquet, Bernard Claverie, Alexandre Moix, Eric Johannssen, Hiromu ARAKAWA, Yoshihiro Togashi, Crisse, Un nouvel Auteur, ";
            Assert.AreEqual(actualAlbum, expectedAlbum);
        }


    }
}
