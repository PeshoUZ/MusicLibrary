using Microsoft.Extensions.DependencyInjection;
using MusicLibrary.Application.Interfaces;
using MusicLibrary.Persitence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Persitence.Configuration
{
    public static class RepositoryConfigurationApplication
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IArtistRepository, ArtistRepository>();
            services.AddScoped<IAlbumRepository, AlbumRepository>();
            services.AddScoped<ITrackRepository, TrackRepository>();
            services.AddScoped<ITrackArtistRepository, TrackArtistRepository>();

            return services;
        }
    }
}
