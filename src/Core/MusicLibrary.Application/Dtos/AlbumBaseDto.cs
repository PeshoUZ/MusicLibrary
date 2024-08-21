using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using AutoMapper.Configuration.Annotations;

namespace MusicLibrary.Application.Dtos
{
    public abstract class AlbumBaseDto
    {
        [Required]
        [Length(5, 100, ErrorMessage = "The Title should be between 5 and 100 symbols")]
        public string? Title { get; set; }
        [Required]
        public DateOnly ReleaseDate { get; set; }
    }
}
