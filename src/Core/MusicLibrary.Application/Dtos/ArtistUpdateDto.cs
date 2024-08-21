using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Dtos
{
    public class ArtistUpdateDto : ArtistBaseDto
    {
        [Required]
        [Length(1, 100, ErrorMessage = "The First Name should be between 1 and 100 symbols")]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
