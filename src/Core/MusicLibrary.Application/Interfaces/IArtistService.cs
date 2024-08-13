using MusicLibrary.Application.Dtos;
using MusicLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Interfaces
{
    public interface IArtistService
    {
        Artist GetArtist(int artistId);
        IEnumerable<Artist> GetArtists();
        void CreateArtist(ArtistCreateDto artist);
        public void UpdateArtist(Artist artist);
        public void DeleteArtist(int artistId);
    }
}
