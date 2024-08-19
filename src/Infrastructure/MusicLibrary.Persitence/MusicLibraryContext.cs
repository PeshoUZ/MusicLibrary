using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MusicLibrary.Domain.Entities;

namespace MusicLibrary.Persitence
{
    public class MusicLibraryContext : DbContext
    {
        public MusicLibraryContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks  { get; set; }
        public DbSet<TrackArtist> TrackArtists { get; set; }

    }
}
