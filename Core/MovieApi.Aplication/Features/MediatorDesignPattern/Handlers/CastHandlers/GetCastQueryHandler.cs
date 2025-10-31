using MediatR;
using Microsoft.EntityFrameworkCore;
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

    public class GetCastQueryHandler : IRequestHandler<GetCastQuery, List<GetCastQueryResult>>
    {
        private readonly MovieContext context;

        public GetCastQueryHandler(MovieContext context)
        {
            this.context = context;
        }
        public async Task<List<GetCastQueryResult>> Handle(GetCastQuery request, CancellationToken cancellationToken)
        {
            var values = await context.Casts.ToListAsync();
            return values.Select(x => new GetCastQueryResult
            {
                CastId = x.CastId,
                Biography = x.Biography,
                Title = x.Title,
                Name = x.Name,
                Surname = x.Surname,
                ImageURL = x.ImageURL,
                Overview = x.Overview
            }).ToList();
        }
    }
}
