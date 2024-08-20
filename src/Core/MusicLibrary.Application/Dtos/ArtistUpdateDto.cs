using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Dtos
{
    public class ArtistUpdateDto : ArtistBaseDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
