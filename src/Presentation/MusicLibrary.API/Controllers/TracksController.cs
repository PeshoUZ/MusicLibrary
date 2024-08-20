using Microsoft.AspNetCore.Mvc;
using MusicLibrary.Application.Dtos;
using MusicLibrary.Application.Interfaces;

namespace MusicLibrary.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrackController : ControllerBase
    {
        //private const string rt = "{id}";
        private readonly ITrackService _trackService;

        public TrackController(ITrackService trackService)
        {
            _trackService = trackService;
        }

        [HttpGet]
        public IEnumerable<TrackGetDto> Get()
        {
            return (IEnumerable<TrackGetDto>)_trackService.GetTracks();
        }

        [HttpGet]
        [Route("{id}")]
        public TrackGetDto GetById(int id)
        {
            return _trackService.GetTrack(id);
        }

        [HttpGet]
        [Route("{id}\\TrackArtist")]
        public IEnumerable<TrackArtistDto> GetArtistsByTrackId(int id)
        {
            return _trackService.GetArtists(id);
        }

        [HttpPost]
        public void Post([FromBody] TrackCreateDto trackDto)
        {
            _trackService.CreateTrack(trackDto);
        }

        [HttpPut]
        [Route("{id}")]
        public void Put(int id, [FromBody] TrackUpdateDto trackDto)
        {
            _trackService.UpdateTrack(id, trackDto);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            _trackService.DeleteTrack(id);
        }
    }
}
