using MovieApi.Aplication.Features.CQRSDesignPattern.Commands.CatagoryCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class RemoveMovieCommandHandler
    {
        public readonly MovieContext _context;

        public RemoveMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handle (RemoveCatagoryCommand command)
        {
            var value = await _context.Movies.FindAsync(command.CatagoryId);
            _context.Movies.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
