using Microsoft.Extensions.DependencyInjection;
using MusicLibrary.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLibrary.Application.Services;

namespace MusicLibrary.Application.Configuration
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection RegisterServices(this IServiceCollection service)
        {
            service.AddScoped<IArtistService, ArtistService>();
            service.AddScoped<IAlbumService, AlbumService>();
            service.AddScoped<ITrackService, TrackService>();

            return service;
        }
    }
}
