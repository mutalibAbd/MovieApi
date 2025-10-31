using MediatR;
using MovieApi.Aplication.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.MediatorDesignPattern.Handlers.CastHandlers
{
    public class UpdateCastCommandHandler : IRequestHandler<UpdateCastCommand>
    {
        private readonly MovieContext context;

        public UpdateCastCommandHandler(MovieContext context)
        {
            this.context = context;
        }

        public async Task Handle(UpdateCastCommand request, CancellationToken cancellationToken)
        {
            var value = await context.Casts.FindAsync(request.CastId);

            value.Surname = request.Surname;
            value.Overview = request.Overview;
            value.ImageURL = request.ImageURL;
            value.Title = request.Title;
            value.Name = request.Name;
            value.Biography = request.Biography;

           await context.SaveChangesAsync();
    }
    }
}
