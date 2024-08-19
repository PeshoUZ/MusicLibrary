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
        public void CreateTrack(TrackCreateDto trackDto)
        {
            var track = new Track
            {
                Title = trackDto.Title,
                Genre = trackDto.Genre,
                DurationSeconds = trackDto.DurationSeconds
            };
        }

        public void DeleteTrack(int trackId)
        {
            _trackRepository.Delete(trackId);
        }

        public Track GetTrack(int trackId)
        {
            return _trackRepository.GetById(trackId);
        }

        public IEnumerable<Track> GetTracks()
        {
            return _trackRepository.GetAll();
        }

        public void UpdateTrack(Track track)
        {
            _trackRepository.Update(track);
        }
    }
}
