using MusicLibrary.Application.Dtos;
using MusicLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Interfaces
{
    public interface IAlbumService
    {
        AlbumGetDto GetAlbum(int albumId);
        IEnumerable<AlbumGetDto> GetAlbums();
        void CreateAlbum(AlbumCreateDto album);
        public void UpdateAlbum(int albumId, AlbumUpdateDto albumDto);
        public void DeleteAlbum(int albumId);
    }
}
