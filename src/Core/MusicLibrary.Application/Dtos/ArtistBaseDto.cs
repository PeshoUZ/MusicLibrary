using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Dtos
{
    public abstract class ArtistBaseDto
    {
        public string? Country { get; set; }
        public string? Pseudonim { get; set; }
    }
}
