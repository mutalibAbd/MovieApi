using MovieApi.Persistence.Context;
using MovieApi.Domain.Entites;
using MovieApi.Aplication.Features.CQRSDesignPattern.Commands.MovieCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class UpdateMoviecommandHandler
    {
        public readonly MovieContext _context;
        public UpdateMoviecommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task handle(UpdateMovieCommands command)
        {
            var value = await _context.Movies.FindAsync(command.MovieId);
            value.Title = command.Title;
            value.CoverimageURL = command.CoverimageURL;    
            value.Rating = command.Rating;
            value.Description = command.Description;
            value.Duration = command.Duration;
            value.ReleaseDate = command.ReleaseDate;
            value.CreatedYear = command.CreatedYear;
            value.Status = command.Status;
            await _context.SaveChangesAsync();
        }
    }
}
