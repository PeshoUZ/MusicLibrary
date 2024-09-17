using Microsoft.EntityFrameworkCore;
using MusicLibrary.Application.Interfaces;
using MusicLibrary.Domain.Entities;
using MusicLibrary.Persitence.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Persitence.Repository
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly ApplicationDbContext _context;

        public AlbumRepository(ApplicationDbContext context)
        {
            _context = context;
        }
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
            var albums = _context.Albums
            .Include(a => a.Artist)
            .Include(a => a.Tracks)
            //.ThenInclude(a => a.TrackArtists)
            //.ThenInclude(a => a.Artist)
            .ToList();
            return albums;
        }

        public Album GetById(int albumId)
        {
            return _context.Albums
                .Include(b => b.Tracks)
                .Include(b =>b.Artist)
                .FirstOrDefault(u => u.AlbumId == albumId)!;

        }

        public void Update(Album album)
        {
            var existingAlbum = _context.Albums.FirstOrDefault(u => u.AlbumId == album.AlbumId);
            if (existingAlbum != null)
            {
                existingAlbum.Title = album.Title;
                existingAlbum.ReleaseDate= album.ReleaseDate;
            }
            else
            {
                throw new Exception("Album not found");
            }
            _context.SaveChanges();
        }
    }
}
