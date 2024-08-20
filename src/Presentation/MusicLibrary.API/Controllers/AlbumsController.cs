using Microsoft.AspNetCore.Mvc;
using MusicLibrary.Application.Dtos;
using MusicLibrary.Application.Interfaces;

namespace MusicLibrary.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        [HttpGet]
        public IEnumerable<AlbumGetDto> Get()
        {
            return (IEnumerable<AlbumGetDto>)_albumService.GetAlbums();
        }

        [HttpGet]
        [Route("{id}")]
        public AlbumGetDto GetById(int id)
        {
            return _albumService.GetAlbum(id);
        }


        [HttpPost]
        public void Post([FromBody] AlbumCreateDto albumDto)
        {
            _albumService.CreateAlbum(albumDto);
        }

        [HttpPut]
        [Route("{id}")]
        public void Put(int id, [FromBody] AlbumUpdateDto albumDto)
        {
            _albumService.UpdateAlbum(id, albumDto);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            _albumService.DeleteAlbum(id);
        }
    }
}
