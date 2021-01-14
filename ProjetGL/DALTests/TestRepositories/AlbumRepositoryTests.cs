using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using DAL.Repositories;

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
        //[TestMethod]
        //public void GetByAuthorTest()
        //{
        //    var albumRepository = new AlbumRepository();
        //    var allAlbum = albumRepository.GetByAuthor("Tome 1 - Planète Dakoï");
        //    string actualAlbum = "";
        //    foreach (Album aa in allAlbum)
        //    {
        //        actualAlbum += aa.ToString() + ", ";
        //    }
        //    string expectedAlbum = "Tome 1 - Planète Dakoï, Bandes dessinées, Soleil Productions, ";
        //    Assert.AreEqual(actualAlbum, expectedAlbum);
        //}








        //[TestMethod]
        //public void AuthorGetAllTest()
        //{
        //    var albumRepository = new AlbumRepository();
        //    var allAlbum = albumRepository.GetAll();
        //    Assert.AreEqual(7, allAlbum.Count);
        //    string actualAlbum = "";
        //    foreach (Album aa in allAlbum)
        //    {
        //        actualAlbum += aa.ToString() + ", ";
        //    }
        //    string expectedAlbum = "Baptiste Pesquet, Bernard Claverie, Alexandre Moix, Eric Johannssen, Hiromu ARAKAWA, Yoshihiro Togashi, Crisse, ";
        //    Assert.AreEqual(actualAlbum, expectedAlbum);
        //}
        //[TestMethod]
        //public void SaveAlbumTest()
        //{
        //    var albumRepository = new AlbumRepository();
        //    var newAlbum = new Album("Un nouvel Auteur");
        //    albumRepository.Save(newAlbum);
        //    var allAlbum = albumRepository.GetAll();
        //    Assert.AreEqual(8, allAlbum.Count);
        //    string actualAlbum = "";
        //    foreach (Album aa in allAlbum)
        //    {
        //        actualAlbum += aa.ToString() + ", ";
        //    }
        //    string expectedAlbum = "Baptiste Pesquet, Bernard Claverie, Alexandre Moix, Eric Johannssen, Hiromu ARAKAWA, Yoshihiro Togashi, Crisse, Un nouvel Auteur, ";
        //    Assert.AreEqual(actualAlbum, expectedAlbum);
        //}
    }
}
