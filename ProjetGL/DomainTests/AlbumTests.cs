using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace DomainTests
{
    [TestClass]
    public class AlbumTests
    {
        private string _title;
        private string _isbn;
        private string _publisher;
        private string _description;
        private List<Author> _authors;
        private List<Genre> _genres;
        private Category _category;
        private Series _series;
        private Album _album;


        [TestInitialize()]
        public void Initialize()
        {
            _authors = new List<Author> {new Author("Baptiste Pesquet")};
            _title = "The JavaScript Way";
            _isbn = "B07C6CTV6S";
            _publisher = "GitBooks";
            _description = "This book aims to be a useful companion for anyone wishing to (re)discover the many facets of JavaScript.";
            _genres = new List<Genre> { new Genre("Informatique") };
            _category = new Category("Apprentissage");
            _series = new Series("BaptistePesquet's Adventures");
            _album = new Album(_title, _isbn, _publisher, _description, _authors, _genres, _category, _series);
        }
        [TestMethod]
        public void TestAlbumToString()
        {
            Assert.AreEqual("The JavaScript Way, Apprentissage, GitBooks", _album.ToString());
        }
    }
}
