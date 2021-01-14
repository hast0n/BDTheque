using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using DAL.Repositories;

namespace DALTests
{
    /// <summary>
    /// Description résumée pour GenreRepositoryTests
    /// </summary>
    [TestClass]
    public class GenreRepositoryTests
    {
        [TestInitialize()]
        public void Initialyse()
        {
            TestRepository.ClearSession();
            TestRepository.ResetBDD();
        }
        [TestMethod]
        public void GenreGetAllTest()
        {
            var genreRepository = new GenreRepository();
            var allGenre = genreRepository.GetAll();
            Assert.AreEqual(7, allGenre.Count);
            string actualGenre = "";
            foreach (Genre aa in allGenre)
            {
                actualGenre += aa.ToString() + ", ";
            }
            string expectedGenre = "Epopée, Science Fiction, Fantasy, Biographie, Polar, Art musique et cinéma, Jeunesse, ";
            Assert.AreEqual(actualGenre, expectedGenre);
        }
        [TestMethod]
        public void SaveUserTest()
        {
            var genreRepository = new GenreRepository();
            var newGenre = new Genre("Un nouveau");
            genreRepository.Save(newGenre);
            var allGenre = genreRepository.GetAll();
            Assert.AreEqual(8, allGenre.Count);
            string actualGenre = "";
            foreach (Genre aa in allGenre)
            {
                actualGenre += aa.ToString() + ", ";
            }
            string expectedGenre = "Epopée, Science Fiction, Fantasy, Biographie, Polar, Art musique et cinéma, Jeunesse, Un nouveau, ";
            Assert.AreEqual(actualGenre, expectedGenre);
        }
    }
}
