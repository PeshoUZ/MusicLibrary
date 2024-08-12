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
        TrackArtist GetById(int artistId, int trackId);
        IEnumerable<TrackArtist> GetAll();
        void Add(Artist artist, Track track);
        void Delete(int artistId, int trackId);
    }
}
