using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Dtos
{
    public class ArtistCreateDto : ArtistBaseDto
    {
        public string? Name { get; set; }
    }
}
