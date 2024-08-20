using AutoMapper;
using MusicLibrary.Application.Dtos;
using MusicLibrary.Application.Interfaces;
using MusicLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Application.Services
{
    public class AlbumService : IAlbumService 
    {
        private readonly IAlbumRepository _albumRepository;
        private readonly IMapper _mapper;

        public AlbumService(IAlbumRepository albumRepository, IMapper mapper)
        {
            _albumRepository = albumRepository;
            _mapper = mapper;
        }
        public void CreateAlbum(AlbumCreateDto albumDto)
        {
            Album album = new Album();
            album = _mapper.Map<Album>(albumDto);
            _albumRepository.Add(album);
        }

        public void DeleteAlbum(int albumId)
        {
            _albumRepository.Delete(albumId);
        }

        public AlbumGetDto GetAlbum(int albumId)
        {
            Album album = _albumRepository.GetById(albumId);
            return _mapper.Map<AlbumGetDto>(album);
        }

        public IEnumerable<AlbumGetDto> GetAlbums()
        {
            var albums = _albumRepository.GetAll();
            return _mapper.Map<IEnumerable<AlbumGetDto>>(albums);
        }

        public void UpdateAlbum(int albumId, AlbumUpdateDto albumDto)
        {
            var album = _albumRepository.GetById(albumId);
            _mapper.Map(albumDto, album);
            _albumRepository.Update(album);
        }
    }
}
