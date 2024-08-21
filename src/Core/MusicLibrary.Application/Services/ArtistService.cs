using AutoMapper;
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
        private readonly ITrackArtistRepository _trackArtistRepository;
        private readonly IMapper _mapper;

        public ArtistService(IArtistRepository artistRepository, ITrackArtistRepository trackArtistReposiotry, IMapper mapper)
        {
            _artistRepository = artistRepository; 
            _trackArtistRepository = trackArtistReposiotry;
            _mapper = mapper;
        }

        public void CreateArtist(ArtistCreateDto artistDto)
        {
            Artist artist = new Artist();
            artist = _mapper.Map<Artist>(artistDto);
            _artistRepository.Add(artist);
        }

        public void DeleteArtist(int artistId)
        {
            _artistRepository.Delete(artistId);
        }

        public ArtistGetDto GetArtist(int artistId)
        {
            Artist artist = _artistRepository.GetById(artistId);
            var artistDto = _mapper.Map<ArtistGetDto>(artist);
            return artistDto;
        }

        public IEnumerable<ArtistGetDto> GetArtists()
        {
            var artists = _artistRepository.GetAll();
            return _mapper.Map<IEnumerable<ArtistGetDto>>(artists);
        }

        public IEnumerable<ArtistTrackDto> GetTracks(int artistId)
        {
            IEnumerable<Track> tracks = _artistRepository.GetTracksByArtistId(artistId);
            return _mapper.Map<IEnumerable<ArtistTrackDto>>(tracks);
        }

        public void UpdateArtist(int artistId, ArtistUpdateDto artistDto)
        {
            var artist = _artistRepository.GetById(artistId);
            _mapper.Map(artistDto, artist);
            _artistRepository.Update(artist);
        }
    }
}
