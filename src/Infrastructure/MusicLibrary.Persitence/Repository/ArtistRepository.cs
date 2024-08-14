using MusicLibrary.Application.Interfaces;
using MusicLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Persitence.Repository
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly MusicLibraryContext _context;

        public void Add(Artist artist)
        {
            _context.Artists.Add(artist);
            _context.SaveChanges();
        }

        public void Delete(int artistId)
        {
            var artist = _context.Artists.FirstOrDefault(u => u.ArtistId == artistId);
            if (artist != null)
            {
                _context.Artists.Remove(artist);
            }
            _context.SaveChanges();
        }

        public IEnumerable<Artist> GetAll()
        {
            return _context.Artists;
        }

        public Artist GetById(int artistId)
        {
            return _context.Artists.FirstOrDefault(u => u.ArtistId == artistId)!;
        }

        public void Update(Artist artist)
        {
            var existingArtist = _context.Artists.FirstOrDefault(u => u.ArtistId == artist.ArtistId);
            if (existingArtist != null)
            {
                existingArtist.FirstName = artist.FirstName;
                existingArtist.LastName = artist.LastName;
                existingArtist.Pseudonim = artist.Pseudonim;
                existingArtist.Country = artist.Country;
            }
            else
            {
                throw new Exception("Artist not found");
            }
            _context.SaveChanges();
        }
    }
}
