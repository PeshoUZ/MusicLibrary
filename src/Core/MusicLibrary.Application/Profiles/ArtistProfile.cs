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

            CreateMap<ArtistUpdateDto, Artist>();

            CreateMap<Artist, ArtistGetDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName));

            CreateMap<Album, ArtistAlbumDto>();

            CreateMap<Track, ArtistTrackDto>();

            CreateMap<Album, AlbumCreateDto>().ReverseMap();
            CreateMap<Album, AlbumUpdateDto>().ReverseMap();
            CreateMap<Album, AlbumGetDto>()
                .ForMember(dest => dest.ArtistName, opt => opt.MapFrom(src => $"{src.Artist.FirstName} {src.Artist.LastName}"))
                .ForMember(dest => dest.Tracks, opt =>opt.MapFrom(src => src.Tracks));

            CreateMap<Track, TrackCreateDto>().ReverseMap();
            CreateMap<Track, TrackUpdateDto>().ReverseMap();
            CreateMap<Track, TrackGetDto>()
                .ForMember(dest => dest.AlbumTitle, opt => opt.MapFrom(src => src.Album.Title))
                .ForMember(dest => dest.Artists, opt => opt.MapFrom(src => src.TrackArtists.Select(ta => ta.Artist)));

            CreateMap<TrackArtist, ArtistGetDto>()
                .ForMember(dest => dest.ArtistId, opt => opt.MapFrom(src => src.ArtistId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => $"{src.Artist.FirstName} {src.Artist.LastName}"));

            CreateMap<TrackArtist, TrackGetDto>()
                .ForMember(dest => dest.TrackId, opt => opt.MapFrom(src => src.TrackId))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Track.Title));
        }
    }
}
