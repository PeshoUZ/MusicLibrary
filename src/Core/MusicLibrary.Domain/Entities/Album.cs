using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Domain.Entities
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string? Title { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public int ArtistId { get; set; }
    }
}
