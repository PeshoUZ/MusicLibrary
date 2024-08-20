using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Dtos
{
    public abstract class TrackBaseDto
    {
        public string? Title { get; set; }
        public TimeSpan Duration { get; set; }
        public string? Genre { get; set; }
    }
}
