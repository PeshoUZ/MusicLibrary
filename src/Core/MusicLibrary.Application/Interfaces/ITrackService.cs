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
        Track GetTrack(int trackId);
        IEnumerable<TrackArtist> GetArtists(int trackId);
        IEnumerable<Track> GetTracks();
        void CreateTrack(TrackCreateDto track);
        public void UpdateTrack(Track track);
        public void DeleteTrack(int trackId);
    }
}
