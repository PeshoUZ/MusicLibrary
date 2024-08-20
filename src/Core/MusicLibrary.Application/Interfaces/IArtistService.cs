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
        ArtistGetDto GetArtist(int artistId);
        IEnumerable<ArtistTrackDto> GetTracks(int artistId);
        IEnumerable<ArtistGetDto> GetArtists();
        void CreateArtist(ArtistCreateDto artist);
        public void UpdateArtist(int artistId, ArtistUpdateDto artistDto);
        public void DeleteArtist(int artistId);
    }
}
