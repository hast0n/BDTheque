using System.Collections;
using System.Collections.Generic;
using Domain;

namespace DAL.Services
{
    public interface IAlbumRepository
    {
        /// <summary>
        /// Get all stored albums
        /// </summary>
        /// <returns> An album collection </returns>
        IList<Album> GetAll();

        /// <summary>
        /// Get an album from storage
        /// </summary>
        /// <returns> The album object associated </returns>
        Album GetAlbum();

        /// <summary>
        /// Remove an album from storage
        /// </summary>
        /// <param name="album"> The album object to remove </param>
        void Delete(Album album);

        /// <summary>
        /// Save or edit an album
        /// </summary>
        /// <param name="album"> The album object to save or edit </param>
        void Save(Album album);

        /// <summary>
        /// Get album cover path
        /// </summary>
        /// <param name="album"> Album to display </param>
        /// <returns> A path to file </returns>
        string GetCover(Album album);
    }
}
