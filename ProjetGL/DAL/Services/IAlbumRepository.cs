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
        /// Get all albums minus ones that user own
        /// </summary>
        /// <returns> A Generic Album List </returns>
        IList<Album> GetMarketAlbums();

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
    }
}
