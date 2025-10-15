using MovieApi.Aplication.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Persistence.Context;
using MovieApi.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class CreatMovieCommandHandleer
    {
        private readonly MovieContext _context;
        public CreatMovieCommandHandleer(MovieContext context)
        {
            _context = context;
        }

        public async void Handle(AddMovieCommands command)
        {
            _context.Movies.Add(new Movie
            {
                Title = command.Title,
                CoverimageURL = command.CoverimageURL,
                Rating = command.Rating,
                Description = command.Description,
                Duration = command.Duration,
                ReleaseDate = command.ReleaseDate,
                CreatedYear = command.CreatedYear,
                Status = command.Status

            });
            await _context.SaveChangesAsync();
        }
    }
}
