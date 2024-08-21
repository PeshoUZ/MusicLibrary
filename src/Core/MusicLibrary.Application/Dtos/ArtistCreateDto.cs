using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Dtos
{
    public class ArtistCreateDto : ArtistBaseDto
    {
        [Required]
        [Length(5, 100, ErrorMessage = "The Name should be between 5 and 100 symbols")]
        public string? Name { get; set; }
    }
}
