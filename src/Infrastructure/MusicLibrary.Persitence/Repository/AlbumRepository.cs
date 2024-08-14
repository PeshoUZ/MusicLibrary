using MusicLibrary.Application.Interfaces;
using MusicLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Persitence.Repository
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly MusicLibraryContext _context; 
        public void Add(Album album)
        {
            throw new NotImplementedException();
        }

        public void Delete(int albumId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Album> GetAll()
        {
            throw new NotImplementedException();
        }

        public Album GetById(int albumId)
        {
            throw new NotImplementedException();
        }

        public void Update(Album album)
        {
            throw new NotImplementedException();
        }
    }
}
