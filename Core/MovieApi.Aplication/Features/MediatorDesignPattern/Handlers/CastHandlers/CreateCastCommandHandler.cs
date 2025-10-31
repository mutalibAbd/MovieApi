using MediatR;
using MovieApi.Aplication.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApi.Persistence.Context;
using System;
using MovieApi.Domain.Entites;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.MediatorDesignPattern.Handlers.CastHandlers
{
    public class CreateCastCommandHandler : IRequestHandler<CreateCastCommand>
    {
        private readonly MovieContext _context;

        public CreateCastCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateCastCommand request, CancellationToken cancellationToken)
        {
             await _context.Casts.AddAsync(new Cast
            {
                ImageURL = request.ImageURL,
                Biography = request.Biography,
                Name = request.Name,
                Overview = request.Overview,
                Surname = request.Surname,
                Title = request.Title,
            });
            await _context.SaveChangesAsync();
        }
    }
}
