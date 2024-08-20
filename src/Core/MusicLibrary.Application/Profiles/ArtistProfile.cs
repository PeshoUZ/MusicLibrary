using AutoMapper;
using MusicLibrary.Application.Dtos;
using MusicLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MusicLibrary.Application.Profiles
{
    public class ArtistProfile : Profile
    {
        public ArtistProfile()
        {
            CreateMap<ArtistCreateDto, Artist>()
                .ForMember(dest => dest.FirstName, 
                opt => opt.MapFrom(src => src.Name.Split(" ", StringSplitOptions.RemoveEmptyEntries).FirstOrDefault()))
                .ForMember(dest => dest.LastName,
                opt => opt.MapFrom(src => src.Name.Split(" ", StringSplitOptions.RemoveEmptyEntries).LastOrDefault()));

            CreateMap<Artist, ArtistGetDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName));

            CreateMap<Album, ArtistAlbumDto>();

            CreateMap<Track, ArtistTrackDto>();
        }
    }
}
