using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Dtos
{
    public class AlbumCreateDto : AlbumBaseDto
    {
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Invalid Id") ]
        public int ArtistId { get; set; }
    }
}
