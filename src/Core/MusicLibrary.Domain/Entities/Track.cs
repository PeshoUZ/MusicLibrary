using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Domain.Entities
{
    public class Track
    {
        [Key]
        public int TrackId { get; set; }
        public string? Title { get; set; }
        public TimeSpan DurationSeconds { get; set; }
        public int AlbumId { get; set; }
        public string? Genre { get; set; }
        public Album? Album { get; set; }
        public ICollection<TrackArtist> TrackArtists { get; set; } = new List<TrackArtist>();
    }
}
