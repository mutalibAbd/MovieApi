using MediatR;
using MovieApi.Aplication.Features.MediatorDesignPattern.Queries.CastQuery;
using MovieApi.Aplication.Features.MediatorDesignPattern.Results.CastResults;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.MediatorDesignPattern.Handlers.CastHandlers
{
    public class GetCastByidQueryHandler : IRequestHandler<GetCastByIdQuery, GetCastByIdQueryResults>
    {

        private readonly MovieContext context;

        public GetCastByidQueryHandler(MovieContext context)
        {
            this.context = context;
        }

        public async Task<GetCastByIdQueryResults> Handle(GetCastByIdQuery request, CancellationToken cancellationToken)
        {

            var value = await context.Casts.FindAsync(request.CastId);
            return new GetCastByIdQueryResults
            {
                CastId = value.CastId,
                Biography = value.Biography,
                Title = value.Title,
                Name = value.Name,
                Surname = value.Surname,
                ImageURL = value.ImageURL,
                Overview = value.Overview
            };
        }


    }
}
