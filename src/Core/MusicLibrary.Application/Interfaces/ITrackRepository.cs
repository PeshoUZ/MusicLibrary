using MusicLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Interfaces
{
    public interface ITrackRepository
    {
        Track GetById(int trackId);
        IEnumerable<Track> GetAll();
        void Add(Track track);
        void Update(Track track);
        void Delete(int trackId);
    }
}
