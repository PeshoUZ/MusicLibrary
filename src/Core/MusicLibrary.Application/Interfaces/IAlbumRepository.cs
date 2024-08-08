using MusicLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Interfaces
{
    public interface IAlbumRepository
    {
        Album GetById(int albumId);
        IEnumerable<Album> GetAll();
        void Add(Album album);
        void Update(Album album);
        void Delete(int albumId);
    }
}
