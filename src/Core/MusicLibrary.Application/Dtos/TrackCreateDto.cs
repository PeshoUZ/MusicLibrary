using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Dtos
{
    public class TrackCreateDto : TrackBaseDto
    {
        public int AlbumID { get; set; }
        public List<int>? ArtistIDs { get; set; }
    }
}
