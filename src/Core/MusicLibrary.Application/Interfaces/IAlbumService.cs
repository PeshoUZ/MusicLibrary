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
        Album GetAlbum(int albumId);
        IEnumerable<Album> GetAlbums();
        void CreateAlbum(ArtistCreateDto album);
        public void UpdateAlbum(Album album);
        public void DeleteAlbum(int albumId);
    }
}
