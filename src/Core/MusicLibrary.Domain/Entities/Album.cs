using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Domain.Entities
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        public string? Title { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public int ArtistId { get; set; }
        public Artist? Artist { get; set; }
        public ICollection<Track> Tracks { get; set; } = new List<Track>();
    }
}
