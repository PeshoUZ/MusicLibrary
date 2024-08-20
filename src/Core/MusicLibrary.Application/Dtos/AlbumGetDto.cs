using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Dtos
{
    public class AlbumGetDto : AlbumBaseDto
    {
        public int AlbumId { get; set; }
        public string? ArtistName { get; set;}
        public IEnumerable<TrackGetDto>? Tracks { get; set; }
    }
}
