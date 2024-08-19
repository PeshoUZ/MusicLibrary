using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Domain.Entities
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Pseudonim { get; set; }
        public string? Country { get; set; }
        public ICollection<Album> Albums { get; set; } = new List<Album>();
        public ICollection<TrackArtist> TrackArtists { get; set; } = new List<TrackArtist>();
    }
}
