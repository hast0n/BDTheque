using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using DAL.Repositories;

namespace DALTests
{
    /// <summary>
    /// Description résumée pour SeriesRepositoryTests
    /// </summary>
    [TestClass]
    public class SeriesRepositoryTests
    {
        [TestInitialize()]
        public void Initialyse()
        {
            TestRepository.ClearSession();
            TestRepository.ResetBDD();
        }
        [TestMethod]
        public void SeriesGetAllTest()
        {
            var seriesRepository = new SeriesRepository();
            var allSeries = seriesRepository.GetAll();
            Assert.AreEqual(4, allSeries.Count);
            string actualSeries = "";
            foreach (Series aa in allSeries)
            {
                actualSeries += aa.ToString() + ", ";
            }
            string expectedSeries = "Les Cryptides, Fullmetal Alchemist, Hunter X Hunter, Kookabura, ";
            Assert.AreEqual(actualSeries, expectedSeries);
        }
        [TestMethod]
        public void SaveUserTest()
        {
            var seriesRepository = new SeriesRepository();
            var newSeries = new Series("Une nouvelle");
            seriesRepository.Save(newSeries);
            var allSeries = seriesRepository.GetAll();
            Assert.AreEqual(5, allSeries.Count);
            string actualSeries = "";
            foreach (Series aa in allSeries)
            {
                actualSeries += aa.ToString() + ", ";
            }
            string expectedSeries = "Les Cryptides, Fullmetal Alchemist, Hunter X Hunter, Kookabura, Une nouvelle, ";
            Assert.AreEqual(actualSeries, expectedSeries);
        }
    }
}
