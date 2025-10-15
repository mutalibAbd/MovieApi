using MovieApi.Aplication.Features.CQRSDesignPattern.Commands.CatagoryCommands;
using MovieApi.Persistence.Context;
using MovieApi.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.CQRSDesignPattern.Handlers.CatagoryHandlers
{
    public class UpdateCatagoryCommandHandler
    {
        public readonly MovieContext _context;

        public UpdateCatagoryCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handle(UpdateCatagoryCommand command)
        {
            var value = await _context.Categories.FindAsync(command.CatagoryId);

            value.CatagoryName = command.CatagoryName;
            await _context.SaveChangesAsync();
        }
    }
}
