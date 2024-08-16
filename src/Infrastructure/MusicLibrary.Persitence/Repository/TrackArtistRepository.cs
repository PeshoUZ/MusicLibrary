using MusicLibrary.Application.Interfaces;
using MusicLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Persitence.Repository
{
    public class TrackArtistRepository : ITrackArtistRepository
    {
        private readonly MusicLibraryContext _context;

        public void Add(TrackArtist trackArtist)
        {
            _context.TrackArtists.Add(trackArtist);
            _context.SaveChanges();
        }

        public void DeleteByArtistId(int artistId)
        {
            var trackArtist = _context.TrackArtists.FirstOrDefault(u => u.ArtistId == artistId);
            if (trackArtist != null)
            {
                _context.TrackArtists.Remove(trackArtist);
            }
            _context.SaveChanges();
        }

        public void DeleteByTrackId(int trackId)
        {
            var trackArtist = _context.TrackArtists.FirstOrDefault(u => u.TrackId == trackId);
            if (trackArtist != null)
            {
                _context.TrackArtists.Remove(trackArtist);
            }
            _context.SaveChanges();
        }

        public IEnumerable<TrackArtist> GetAll()
        {
            return _context.TrackArtists;
        }

        public TrackArtist GetByArtistId(int artistId)
        {
            return _context.TrackArtists.FirstOrDefault(u => u.ArtistId == artistId)!;
        }

        public TrackArtist GetByTrackId(int trackId)
        {
            return _context.TrackArtists.FirstOrDefault(u => u.TrackId == trackId)!;
        }
    }
}
