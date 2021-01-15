using Domain;
using System.Collections.Generic;

namespace DAL.Services
{
    public interface IAlbumRepository
    {
        /// <summary>
        /// Save or update an album
        /// </summary>
        /// <param name="album"> The album object </param>
        void Save(Album album);

        /// <summary>
        /// Get an album object by its ID
        /// </summary>
        /// <param name="id"> album's corresponding ID in Database </param>
        /// <returns> An album object </returns>
        Album GetAlbumById(int id);
        
        /// <summary>
        /// Get all albums in database
        /// </summary>
        /// <returns> A Generic Album List </returns>
        IList<Album> GetAll();

        /// <summary>
        /// Get albums by title or sub-part of title
        /// </summary>
        /// <param name="title"> title string </param>
        /// <returns> A Generic Album List </returns>
        IList<Album> GetByTitle(string title);

        /// <summary>
        /// Get albums by author
        /// </summary>
        /// <param name="author"> author name string </param>
        /// <returns> A Generic Album List </returns>
        IList<Album> GetByAuthor(string author);

        /// <summary>
        /// Get albums by series
        /// </summary>
        /// <param name="series"> series name string </param>
        /// <returns> A Generic Album List </returns>
        IList<Album> GetBySeries(string series);

        /// <summary>
        /// Get albums by genre
        /// </summary>
        /// <param name="genre"> genre name string </param>
        /// <returns> A Generic Album List </returns>
        IList<Album> GetByGenre(string genre);

        /// <summary>
        /// Get available authors
        /// </summary>
        /// <returns> an Author generic List </returns>
        IList<Author> GetAuthors();

        /// <summary>
        /// Get available series
        /// </summary>
        /// <returns> a Series generic List </returns>
        IList<Series> GetSeries();

        /// <summary>
        /// Get available genres
        /// </summary>
        /// <returns> a Genre generic List </returns>
        IList<Genre> GetGenres();

        /// <summary>
        /// Get available categories
        /// </summary>
        /// <returns> a Category generic List </returns>
        IList<Category> GetCategories();
    }
}
