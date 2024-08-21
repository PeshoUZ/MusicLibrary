using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Dtos
{
    public class TrackGetDto : TrackBaseDto
    {
        public int TrackId { get; set; }
        public string? AlbumTitle { get; set; }
        public List<ArtistGetDto>? Artists { get; set; }
    }
}
