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
    public class ArtistService : IArtistService
    {
        private readonly IArtistRepository _artistRepository;

        public ArtistService(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }

        public void CreateArtist(ArtistCreateDto artistDto)
        {
            var artist = new Artist
            {
                ArtistId = GenerateArtistId(),
                FirstName = artistDto.FirstName,
                LastName = artistDto.LastName,
                Pseudonim = artistDto.Pseudonim,
                Country = artistDto.Country
            };
        }

        public void DeleteArtist(int artistId)
        {
            _artistRepository.Delete(artistId);
        }

        public Artist GetArtist(int artistId)
        {
            return _artistRepository.GetById(artistId);
        }

        public IEnumerable<Artist> GetArtists()
        {
            return _artistRepository.GetAll();
        }

        public void UpdateArtist(Artist artist)
        {
            _artistRepository.Update(artist);
        }

        private int GenerateArtistId() => _artistRepository.GetAll().Count() + 1;
    }
}
