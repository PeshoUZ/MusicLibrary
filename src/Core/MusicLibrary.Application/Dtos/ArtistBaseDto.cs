using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Dtos
{
    public abstract class ArtistBaseDto
    {
        [Required]
        [Length(5, 100, ErrorMessage = "The Country should be between 5 and 100 symbols")]
        public string? Country { get; set; }
        [Required]
        [Length(5, 100, ErrorMessage = "The Pseudonim should be between 5 and 100 symbols")]
        public string? Pseudonim { get; set; }
    }
}
