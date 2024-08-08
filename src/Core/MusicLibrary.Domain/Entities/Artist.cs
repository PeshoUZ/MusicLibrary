using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Domain.Entities
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Pseudonim { get; set; }
        public string? Country { get; set; }
    }
}
