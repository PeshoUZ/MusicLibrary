using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Dtos
{
    public class ArtistGetDto : ArtistBaseDto
    {
        public int ArtistId { get; set; }
        public string? Name { get; set; }
        public List<AlbumGetDto>? Albums {  get; set; }
    }
}
