using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MusicLibrary.Application.Dtos
{
    public abstract class AlbumBaseDto
    {
        
        public string? Title { get; set; }
        public DateOnly ReleaseDate { get; set; }
    }
}
