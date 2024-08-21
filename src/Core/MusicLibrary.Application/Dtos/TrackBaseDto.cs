using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Dtos
{
    public abstract class TrackBaseDto
    {
        [Required]
        [Length(5, 100, ErrorMessage = "The Title should be between 5 and 100 symbols")]
        public string? Title { get; set; }
        [Required]
        [Length(8, 8, ErrorMessage = "The Duration should be in this way 00:00:00")]
        public string Duration { get; set; } = "00:00:00";
        [Required]
        [Length(2, 100, ErrorMessage = "The Genre should be between 2 and 100 symbols")]
        public string? Genre { get; set; }
    }
}
