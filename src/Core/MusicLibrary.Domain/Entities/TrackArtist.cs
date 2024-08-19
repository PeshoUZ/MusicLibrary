using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Domain.Entities
{
    public class TrackArtist
    {
        [Key]
        public int TrackId { get; set; }
        public int ArtistId { get; set; }
    }
}
