using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Dtos
{
    public class TrackArtistCreateDto
    {
        public int TrackId { get; set; }
        public int ArtistId { get; set; }
    }
}
