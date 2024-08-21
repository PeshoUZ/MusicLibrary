using AutoMapper;
using MusicLibrary.Application.Dtos;
using MusicLibrary.Application.Interfaces;
using MusicLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Services
{
    public class TrackService : ITrackService
    {
        private readonly ITrackRepository _trackRepository;
        private readonly ITrackArtistRepository _trackArtistRepository;
        private readonly IMapper _mapper;

        public TrackService(ITrackRepository trackRepository, ITrackArtistRepository trackArtistRepository, IMapper mapper)
        {
            _trackRepository = trackRepository;
            _trackArtistRepository = trackArtistRepository;
            _mapper = mapper;
        }

        public void CreateTrack(TrackCreateDto trackDto)
        {
            Track track = new Track();
            track = _mapper.Map<Track>(trackDto);
            _trackRepository.Add(track);
            foreach(int id in trackDto.ArtistIDs)
            {
                TrackArtist trackArtist = new TrackArtist();
                trackArtist.ArtistId = id;
                trackArtist.TrackId = track.TrackId;
                _trackArtistRepository.Add(trackArtist);
            }
        }

        public void DeleteTrack(int trackId)
        {
            _trackRepository.Delete(trackId);
        }

        public IEnumerable<TrackArtistDto> GetArtists(int trackId)
        {
            IEnumerable<Artist> artists = _trackRepository.GetArtistsByTrackId(trackId);
            return _mapper.Map<IEnumerable<TrackArtistDto>>(artists);
        }

        public TrackGetDto GetTrack(int trackId)
        {
            var track = _trackRepository.GetById(trackId);
            return _mapper.Map<TrackGetDto>(track);
        }

        public IEnumerable<TrackGetDto> GetTracks()
        {
            var tracks = _trackRepository.GetAll();
            return _mapper.Map<IEnumerable<TrackGetDto>>(tracks);
        }

        public IEnumerable<TrackGetDto> GetTracksByGenre(string Genre)
        {
            var tracks = _trackRepository.GetTracksByTheirGenre(Genre);
            return _mapper.Map<IEnumerable<TrackGetDto>>(tracks);
        }

        public void UpdateTrack(int trackId, TrackUpdateDto trackDto)
        {
            var track = _trackRepository.GetById(trackId);
            _mapper.Map(trackDto, track);
            _trackRepository.Update(track);
        }
    }
}
