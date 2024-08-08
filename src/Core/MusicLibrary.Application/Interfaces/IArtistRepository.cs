using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLibrary.Domain.Entities;

namespace MusicLibrary.Application.Interfaces
{
    public interface IArtistRepository
    {
        Artist GetById(int artistId);
        IEnumerable<Artist> GetAll();
        void Add(Artist artist);
        void Update(Artist artist);
        void Delete(int artistId);
    }
}
