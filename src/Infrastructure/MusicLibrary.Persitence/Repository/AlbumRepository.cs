using MusicLibrary.Application.Interfaces;
using MusicLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Persitence.Repository
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly MusicLibraryContext _context;
        public void Add(Album album)
        {
            _context.Albums.Add(album);
            _context.SaveChanges();
        }

        public void Delete(int albumId)
        {
            var album = _context.Albums.FirstOrDefault(u => u.AlbumId == albumId);
            if (album != null)
            {
                _context.Albums.Remove(album);
            }
            _context.SaveChanges();
        }

        public IEnumerable<Album> GetAll()
        {
            return _context.Albums;
        }

        public Album GetById(int albumId)
        {
            return _context.Albums.FirstOrDefault(u => u.AlbumId == albumId)!;
        }

        public void Update(Album album)
        {
            var existingAlbum = _context.Albums.FirstOrDefault(u => u.AlbumId == album.ArtistId);
            if (existingAlbum != null)
            {
                existingAlbum.Title = album.Title;
                existingAlbum.ReleaseDate= album.ReleaseDate;
                existingAlbum.ArtistId = album.ArtistId;
            }
            else
            {
                throw new Exception("Album not found");
            }
            _context.SaveChanges();
        }
    }
}
