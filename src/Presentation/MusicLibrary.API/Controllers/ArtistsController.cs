using Microsoft.AspNetCore.Mvc;
using MusicLibrary.Application.Dtos;
using MusicLibrary.Application.Interfaces;
using MusicLibrary.Domain.Entities;

namespace MusicLibrary.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtistController : ControllerBase
    {
        //private const string rt = "{id}";
        private readonly IArtistService _artistService;

        public ArtistController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        [HttpGet]
        public IEnumerable<ArtistGetDto> Get()
        {
            return (IEnumerable<ArtistGetDto>)_artistService.GetArtists();
        }

        [HttpGet]
        [Route("{id}")]
        public ArtistGetDto GetById(int id)
        {
            return _artistService.GetArtist(id);
        }

        [HttpGet]
        [Route("{id}\\ArtistTrack")]
        public IEnumerable<ArtistTrackDto> GetTracksByArtistId(int id)
        { 
            return _artistService.GetTracks(id);
        }

        [HttpPost]
        public void Post([FromBody] ArtistCreateDto artistDto)
        {
            _artistService.CreateArtist(artistDto);
        }

        [HttpPut]
        [Route("{id}")]
        public void Put(int id, [FromBody] ArtistUpdateDto artistDto)
        {
            _artistService.UpdateArtist(id, artistDto);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            _artistService.DeleteArtist(id);
        }
    }
}
