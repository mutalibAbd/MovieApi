using MediatR;
using MovieApi.Aplication.Features.MediatorDesignPattern.Commands.TagCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    
    public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand>
    {
        public readonly MovieContext context;

        public UpdateTagCommandHandler(MovieContext context)
        {
            this.context = context;
        }

        public async Task Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            var value = await context.Tags.FindAsync(request.TagId);

            value.TagId = request.TagId;
            value.Title = request.Title;
            await context.SaveChangesAsync();
            
        }
    }
}
