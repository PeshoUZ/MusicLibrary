using MusicLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Interfaces
{
    public interface ITrackArtistRepository
    {
        TrackArtist GetByArtistId(int artistId);
        TrackArtist GetByTrackId(int trackId);
        IEnumerable<TrackArtist> GetAll();
        void Add(TrackArtist trackArtist);
        void DeleteByArtistId(int artistId);
        void DeleteByTrackId(int trackId);
    }
}
