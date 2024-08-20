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
    public class TrackRepository : ITrackRepository
    {
        private readonly ApplicationDbContext _context;
        public void Add(Track track)
        {
            _context.Tracks.Add(track);
            _context.SaveChanges();
        }

        public void Delete(int trackId)
        {
            var track = _context.Tracks.FirstOrDefault(u => u.TrackId == trackId);
            if (track != null)
            {
                _context.Tracks.Remove(track);
            }
            _context.SaveChanges();
        }

        public IEnumerable<Track> GetAll()
        {
            return _context.Tracks;
        }

        public IEnumerable<Artist> GetArtistsByTrackId(int trackId)
        {
            return _context.Artists
                .Include(b => b.TrackArtists)
                .Where(u => u.TrackArtists.Any(c => c.TrackId == trackId));
        }

        public Track GetById(int trackId)
        {
            return _context.Tracks
                .FirstOrDefault(u => u.TrackId == trackId)!;
        }

        public void Update(Track track)
        {
            var existingTrack = _context.Tracks.FirstOrDefault(u => u.TrackId == track.TrackId);
            if (existingTrack != null)
            {
                existingTrack.Title = track.Title;
                existingTrack.DurationSeconds = track.DurationSeconds;
                existingTrack.AlbumId = track.AlbumId;
            }
            else
            {
                throw new Exception("Track not found");
            }
            _context.SaveChanges();
        }
    }
}
