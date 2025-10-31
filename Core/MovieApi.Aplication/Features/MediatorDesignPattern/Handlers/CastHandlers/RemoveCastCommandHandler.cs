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
    public class RemoveCastCommandHandler : IRequestHandler<RemoveCastCommand>
    {
        private readonly MovieContext context;

        public RemoveCastCommandHandler(MovieContext context)
        {
            this.context = context;
        }

        public async Task Handle(RemoveCastCommand request, CancellationToken cancellationToken)
        {
            var value = await context.Casts.FindAsync(request.CastId);

            context.Casts.Remove(value);
            await context.SaveChangesAsync();

        }
    }
}
