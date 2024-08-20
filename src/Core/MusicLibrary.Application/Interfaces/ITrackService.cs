using MusicLibrary.Application.Dtos;
using MusicLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Interfaces
{
    public interface ITrackService
    {
        TrackGetDto GetTrack(int trackId);
        IEnumerable<TrackArtistDto> GetArtists(int trackId);
        IEnumerable<TrackGetDto> GetTracks();
        void CreateTrack(TrackCreateDto track);
        public void UpdateTrack(int trackId, TrackUpdateDto trackDto);
        public void DeleteTrack(int trackId);
    }
}
