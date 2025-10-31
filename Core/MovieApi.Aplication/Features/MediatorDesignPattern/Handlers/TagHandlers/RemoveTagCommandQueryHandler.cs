using MediatR;
using MovieApi.Aplication.Features.MediatorDesignPattern.Commands.TagCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class RemoveTagCommandQueryHandler: IRequestHandler<RemoveTagCommand>
    {
        private readonly MovieContext context;

        public RemoveTagCommandQueryHandler(MovieContext context)
        {
            this.context = context;
        }

        public async Task Handle(RemoveTagCommand request, CancellationToken cancellationToken)
        {
            var value = await context.Tags.FindAsync(request.TagId);

            context.Tags.Remove(value);
            await context.SaveChangesAsync();
        }
    }
}
