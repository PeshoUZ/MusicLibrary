using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Dtos
{
    public class TrackCreateDto
    {
        public int TrackId { get; set; }
        public string? Title { get; set; }
        public int DurationSeconds { get; set; }
        public int AlbumId { get; set; }
        public string? Genre { get; set; }
    }
}
