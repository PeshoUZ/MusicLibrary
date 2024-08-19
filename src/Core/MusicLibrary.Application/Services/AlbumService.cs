using MusicLibrary.Application.Dtos;
using MusicLibrary.Application.Interfaces;
using MusicLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Services
{
    public class AlbumService : IAlbumService 
    {
        private readonly IAlbumRepository _albumRepository;
        public void CreateAlbum(AlbumCreateDto albumDto)
        {
            var album = new Album
            { 
                Title = albumDto.Title,
                ReleaseDate = albumDto.ReleaseDate
            };
        }

        public void DeleteAlbum(int albumId)
        {
            _albumRepository.Delete(albumId);
        }

        public Album GetAlbum(int albumId)
        {
            return _albumRepository.GetById(albumId);
        }

        public IEnumerable<Album> GetAlbums()
        {
            return _albumRepository.GetAll();
        }

        public void UpdateAlbum(Album album)
        {
            _albumRepository.Update(album);
        }
    }
}
